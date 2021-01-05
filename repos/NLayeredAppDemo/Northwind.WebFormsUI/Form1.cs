using NLayeredAppDemo.Abstract;
using NLayeredAppDemo.Concrete;
using NLayeredAppDemo.DependencyResolver.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Ürünler : Form
    {
        public Ürünler()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private IProductService _productService;
        private ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();

        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName"; //Görünen kategori ismi olmalı
            cbxCategory.ValueMember = "CategoryId"; //Seçilen kategori id olmalı

            comboBoxCategory.DataSource = _categoryService.GetAll();
            comboBoxCategory.DisplayMember = "CategoryName"; //Görünen kategori ismi olmalı
            comboBoxCategory.ValueMember = "CategoryId"; //Seçilen kategori id olmalı
        }

        private void LoadProducts()
        {
            dgvProduct.DataSource = _productService.GetAll();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));

            }
            catch 
            {
                               
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text)) //eğer textboxda değer varsa ona göre getir
            {
                dgvProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);

            }
            else
            {
                LoadProducts();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(comboBoxCategory.SelectedValue),
                    ProductName = cbxProductName2.Text,
                    UnitPrice = Convert.ToInt32(cbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(cbxStockAmount.Text),
                    QuantityPerUnit = cbxQuantity.Text

                });
                MessageBox.Show("Ürün kaydedildi.");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value)

                    });
                    MessageBox.Show("Ürün Silindi.");
                    LoadProducts();

                }
                catch
                {


                }
            }

        } 
    }
}
