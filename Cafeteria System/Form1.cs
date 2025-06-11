using System;
using System.Data;
using System.Drawing;
using BuisnessLayer;
using BuisnessLayer.Services;
using DAL.Data;
using DAL.Migrations;
using DAL.Repository;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Cafeteria_System
{
    public partial class Form1 : Form
    {
        ProductService productService;


        public Form1()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            //    using(var context =new )
            //     {
            //            ProductRepository productRepository=new ProductRepository ();   
            //    productService = new ProductService();
            //    }






        }





        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
