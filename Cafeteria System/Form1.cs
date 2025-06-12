using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BuisnessLayer.Services;
using DAL.Data;
using DAL.Repository;
using Models;

namespace Cafeteria_System
{
    public partial class Form1 : Form
    {
        private readonly ProductService _productService;
        private readonly OrderService _orderService;
        private readonly CategoryService _categoryService;

        private List<OrderItem> currentOrderItems = new List<OrderItem>();
        private List<Product> GetProductsByCategoryId = new List<Product>();



        public Form1()
        {
            InitializeComponent();

            var dbContext = new ApplicationDbContext();
            var productRepo = new ProductRepository(dbContext);
            var orderRepo = new OrderRepository(dbContext);
            var categoryRepo = new CategoryRepository(dbContext);

            _productService = new ProductService(productRepo);
            _orderService = new OrderService(orderRepo);
            _categoryService = new CategoryService(categoryRepo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Load all products and categories
        private void LoadData()
        {
            LoadCategories();
            LoadProducts();
            nudQuantity.Minimum = 1;
            nudQuantity.Value = 1;
        }

        // Load all categories into ComboBox
        private void LoadCategories()
        {
            var categories = _categoryService.GetAllCategories().ToList();


            categories.Insert(0, new Category
            {
                Id = 0,
                Title = "All"
            });

            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Title";
            cmbCategory.ValueMember = "Id";
        }



        // Load products (optionally filtered by category)
        private void LoadProducts(int categoryId = 0)
        {
            var products = (categoryId == 0)
                ? _productService.GetAllProducts()
                : _productService.GetProductsByCategoryId(categoryId);

            if (products == null || !products.Any())
            {
                dataGridViewProducts.DataSource = null;
                MessageBox.Show("No products found.");
                return;
            }

            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = products;

          
            dataGridViewProducts.Columns["Id"].Visible = false;
            dataGridViewProducts.Columns["Cost"].Visible = false;
            dataGridViewProducts.Columns["NumberOfUnitsInStore"].Visible = false;
            dataGridViewProducts.Columns["IsStock"].Visible = false;
            dataGridViewProducts.Columns["IsBestSeller"].Visible = false;
            dataGridViewProducts.Columns["CategoryId"].Visible = false;
            dataGridViewProducts.Columns["Inventory"].Visible = false;
            dataGridViewProducts.Columns["OrderItem"].Visible = false;
            dataGridViewProducts.Columns["IsBestSeller"].Visible = false;
            dataGridViewProducts.Columns["IsBestSeller"].Visible = false;
        }




        // ComboBox category selection changed
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCategoryId = (int)cmbCategory.SelectedValue;
            LoadProducts(selectedCategoryId);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            var selectedProduct = (Product)dataGridViewProducts.CurrentRow.DataBoundItem;
            int quantity = (int)nudQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            if (quantity > selectedProduct.NumberOfUnitsInStore)
            {
                MessageBox.Show($"Only {selectedProduct.NumberOfUnitsInStore} units available in stock.");
                return;
            }

            var existingItem = currentOrderItems.FirstOrDefault(oi => oi.ProductId == selectedProduct.Id);
            if (existingItem != null)
            {
                existingItem.NumberOfUnits += quantity;
            }
            else
            {
                currentOrderItems.Add(new OrderItem
                {
                    ProductId = selectedProduct.Id,
                    Product = selectedProduct,
                    NumberOfUnits = quantity
                });
            }

            RefreshOrderGrid();
            UpdateTotal();
        }

        private void RefreshOrderGrid()
        {
            dataGridViewOrderItems.DataSource = null;
            dataGridViewOrderItems.DataSource = currentOrderItems
                .Select(oi => new
                {
                    ProductName = oi.Product.ProductName,
                    Quantity = oi.NumberOfUnits,
                    Price = oi.Product.PricePerUnit,
                    Total = oi.NumberOfUnits * oi.Product.PricePerUnit
                }).ToList();
        }

        private void UpdateTotal()
        {
            decimal total = currentOrderItems.Sum(item => item.NumberOfUnits * item.Product.PricePerUnit);
            lblTotal.Text = $"Total: {total:C}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!currentOrderItems.Any())
            {
                MessageBox.Show("No items in the order.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to submit this order?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            decimal total = currentOrderItems.Sum(item => item.NumberOfUnits * item.Product.PricePerUnit);

            var order = new Order
            {
                CreatedAt = DateTime.Now,
                Total = total,
                OrderItems = currentOrderItems
            };

            _orderService.AddOrder(order);

            foreach (var item in currentOrderItems)
            {
                var newStock = item.Product.NumberOfUnitsInStore - item.NumberOfUnits;
                _productService.UpdateNumberOfUnitsInStore(item.ProductId, newStock);
            }

            MessageBox.Show("Order submitted successfully!");

            currentOrderItems.Clear();
            RefreshOrderGrid();
            UpdateTotal();
            LoadProducts();

        }

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cmbCategory.SelectedValue != null && int.TryParse(cmbCategory.SelectedValue.ToString(), out int selectedCategoryId))
            {

                LoadProducts(selectedCategoryId);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
         
            if (!currentOrderItems.Any())
            {
                MessageBox.Show("No items in the order.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to submit this order?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            decimal total = currentOrderItems.Sum(item => item.NumberOfUnits * item.Product.PricePerUnit);

            var order = new Order
            {
                CreatedAt = DateTime.Now,
                Total = total,
                OrderItems = currentOrderItems
            };

            _orderService.AddOrder(order);

            
            foreach (var item in currentOrderItems)
            {
                int newStock = item.Product.NumberOfUnitsInStore - item.NumberOfUnits;
                _productService.UpdateNumberOfUnitsInStore(item.ProductId, newStock);
            }

            MessageBox.Show("Order submitted successfully!");

           
            currentOrderItems.Clear();
            RefreshOrderGrid();
            UpdateTotal();
            LoadProducts(); 
        }

    }
}


