using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_1_Navneet_4531978
{
    public partial class MainWindow : Window
    {

    
        public MainWindow()
        {
            InitializeComponent();
               LoadComboBoxData();
        }

        Product_Context db = new Product_Context();


        private void LoadEvent()
        {
            var Product = db.Product.ToList();
            Prop_Grid.ItemsSource= Product;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          LoadEvent();
        }

       
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Prop_Grid.ItemsSource = null;
            Cat_Combo.ItemsSource = null;
        }


        public class ComboBoxItemData
        {
            public int ID { get; set; }
            public string? Name { get; set; }

            // Override ToString to display the Name in the ComboBox
            public override string ToString()
            {
                return Name;
            }
        }

        private void LoadComboBoxData()
        {
            List<ComboBoxItemData> items = new List<ComboBoxItemData>
            {
                new ComboBoxItemData { ID = 1, Name = "Household" },
                new ComboBoxItemData { ID = 2, Name = "Groceries" },
                new ComboBoxItemData { ID = 3, Name = "Electronics" },
                new ComboBoxItemData { ID = 4, Name = "Sports" },
                new ComboBoxItemData { ID = 5, Name = "Concerts" },
                new ComboBoxItemData { ID = 6, Name = "Shows" },
                new ComboBoxItemData { ID = 7, Name = "Musicals" },
                new ComboBoxItemData { ID = 8, Name = "Fashion" },
                new ComboBoxItemData { ID = 9, Name = "Toys" },
                new ComboBoxItemData { ID = 10, Name = "BabyCare" }
            };

            Cat_Combo.ItemsSource = items;
        }


        private void Categoryloader()
        {
            if (Cat_Combo.SelectedItem is ComboBoxItemData selectedItem)
            {
                var data = db.Product.Where(p => p.CategoryID == selectedItem.ID);
                Prop_Grid.ItemsSource = data.ToList();
            }
        }

        private void Cat_Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Categoryloader();
        }

     

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var data = db.Product.Where(e=>e.ProductName==txt_Product.Text);
            if(data==null)
            {
                MessageBox.Show("product not found");
                
            }
            else
            Prop_Grid.ItemsSource = data.ToList();
        }
    }
}