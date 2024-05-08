using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        private List<Product> _products;

        public Form1()
        {
            InitializeComponent();
            _products = new List<Product>();

            // Додати початкові дані (для демонстрації)
            _products.Add(new Product("Сальце", 10.99m, "Закуска"));
            _products.Add(new Product("Хрончик", 20.99m, "Овочі"));
            _products.Add(new Product("Цибулина", 30.99m, "Закуска"));

            // Відобразити список товарів
            UpdateProductList();

            // Заповнити комбо-бокс категорій
            FillCategoryComboBox();
        }

        private void FillCategoryComboBox()
        {
            var categories = new HashSet<string>();
            foreach (var product in _products)
            {
                categories.Add(product.Category);
            }
            cmbCategory.DataSource = new List<string>(categories);
        }

        private void UpdateProductList(List<Product> products)
        {
            lstProducts.Items.Clear();
            foreach (var product in products)
            {
                lstProducts.Items.Add($"{product.Name} - {product.Price:C} - {product.Category}");
            }
        }

        private void UpdateProductList()
        {
            lstProducts.Items.Clear();
            foreach (var product in _products)
            {
                lstProducts.Items.Add($"{product.Name} - {product.Price:C} - {product.Category}");
            }
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                var newProduct = addProductForm.GetProduct();
                _products.Add(newProduct);
                UpdateProductList();
                FillCategoryComboBox(); // Оновлюємо комбо-бокс категорій
            }
        }
        public void AddProductToList(Product product)
        {
            _products.Add(product);
            UpdateProductList();
        }
        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            var selectedCategory = cmbCategory.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                var filteredProducts = _products.FindAll(product => product.Category == selectedCategory);
                UpdateProductList(filteredProducts); // Оновлюємо список товарів з врахуванням фільтрації
            }
        }

      
    }



}

public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Product(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }

   
