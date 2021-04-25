
using IcelandDev;
using IcelandDev.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        List<string> products = new List<string>(); //Product types to select for ItemName
        List<ItemModel> items = GetTestItems("TestInputOriginal.txt"); //Sets to original for demo, in practice this text file should be updated
        public Form1()
        {
            InitializeComponent();

            BindDropdown();

            UpdateGvItems();
        }
        public static List<ItemModel> GetTestItems(string inputTextFile)
        {
            List<ItemModel> output = new List<ItemModel>();
            string[] content = File.ReadAllLines(inputTextFile);

            foreach (string line in content)
            {
                string[] data = line.Split(',');
                output.Add(new ItemModel { ItemName = data[0], SellIn = Int32.Parse(data[1]), Qty = Int32.Parse(data[2]) });
            }

            return output;
        }

        public void BindDropdown()
        {
            //Selectable product types
            products.Add("Aged Brie");
            products.Add("Christmas Crackers");
            products.Add("Soap");
            products.Add("Frozen Item");
            products.Add("Fresh Item");
            itemDropdown.DataSource = null;
            itemDropdown.DataSource = products;
        }

        public void UpdateGvItems()
        {
            //Updates Gridview in UI
            var source = new BindingSource();
            source.DataSource = items;
            gvItems.DataSource = source;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Adds Item to List and returns updated list
            items = AddItem.AddNewItem(new ItemModel { ItemName = itemDropdown.SelectedItem.ToString(), SellIn = (int)tbSellIn.Value, Qty = (int)tbQty.Value }, items);

            UpdateGvItems();
            
            //Sets default values
            tbSellIn.Value = 0;
            tbQty.Value = 0;
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            //returns updated Sell In and Quality values for items in list
            items = NextDay.UpdateSellInAndQty(items, products);

            UpdateGvItems();
        }
    }
}
