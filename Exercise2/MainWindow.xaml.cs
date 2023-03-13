using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercise2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<AppetizerMenu> appetizermenus = new List<AppetizerMenu>();
        public List<BeverageMenu> beveragemenus = new List<BeverageMenu>();
        public List<MainCourseMenu> maincoursemenus = new List<MainCourseMenu>();
        public List<DessertMenu> dessertmenus = new List<DessertMenu>();
        private List<object> selectedItems = new List<object>();

        public MainWindow()
        {
            InitializeComponent();

            appetizermenus.Add(new AppetizerMenu { AppetizerName = "Buffalo Wing", AppetizerPrice = "$5.95", IsAdd = false });
            appetizermenus.Add(new AppetizerMenu { AppetizerName = "Buffalo Fingers", AppetizerPrice = "$6.95", IsAdd = false });
            appetizermenus.Add(new AppetizerMenu { AppetizerName = "Potato Skins", AppetizerPrice = "$8.95", IsAdd = false });
            appetizermenus.Add(new AppetizerMenu { AppetizerName = "Nachos", AppetizerPrice = "$8.95", IsAdd = false });
            appetizermenus.Add(new AppetizerMenu { AppetizerName = "Mushroom Caps", AppetizerPrice = "$10.95", IsAdd = false });
            appetizermenus.Add(new AppetizerMenu { AppetizerName = "Shrimp Cocktail", AppetizerPrice = "$12.95", IsAdd = false });
            appetizermenus.Add(new AppetizerMenu { AppetizerName = "Chips and Salsa", AppetizerPrice = "$6.95", IsAdd = false });
            Appetizer_ComboBox.ItemsSource = appetizermenus;

            beveragemenus.Add(new BeverageMenu { BeverageName = "Buffalo Wing", BeveragePrice = "$5.95", IsAdd = false });
            beveragemenus.Add(new BeverageMenu { BeverageName = "Coffee", BeveragePrice = "$1.95", IsAdd = false });
            beveragemenus.Add(new BeverageMenu { BeverageName = "Coke", BeveragePrice = "$1.25", IsAdd = false });
            beveragemenus.Add(new BeverageMenu { BeverageName = "Diet Coke", BeveragePrice = "$1.25", IsAdd = false });
            beveragemenus.Add(new BeverageMenu { BeverageName = "Sprite", BeveragePrice = "$1.25", IsAdd = false });
            beveragemenus.Add(new BeverageMenu { BeverageName = "Lemonade", BeveragePrice = "$1.95", IsAdd = false });
            beveragemenus.Add(new BeverageMenu { BeverageName = "Iced Tea", BeveragePrice = "$1.50", IsAdd = false });
            Beverage_ComboBox.ItemsSource = beveragemenus;

            maincoursemenus.Add(new MainCourseMenu { MainCourseName = "Buffalo Wing", MainCoursePrice = "$5.95", IsAdd = false });
            maincoursemenus.Add(new MainCourseMenu { MainCourseName = "Seafood Alfredo", MainCoursePrice = "$15.99", IsAdd = false });
            maincoursemenus.Add(new MainCourseMenu { MainCourseName = "Chicken Alfredo", MainCoursePrice = "$13.99", IsAdd = false });
            maincoursemenus.Add(new MainCourseMenu { MainCourseName = "Chicken Picatta", MainCoursePrice = "$13.99", IsAdd = false });
            maincoursemenus.Add(new MainCourseMenu { MainCourseName = "Turkey Club", MainCoursePrice = "$11.99", IsAdd = false });
            maincoursemenus.Add(new MainCourseMenu { MainCourseName = "Lobster Pie", MainCoursePrice = "$19.99", IsAdd = false });
            MainCourse_ComboBox.ItemsSource = maincoursemenus;

            dessertmenus.Add(new DessertMenu { DessertName = "Mango HK", DessertPrice = "$5.95", IsAdd = false });
            dessertmenus.Add(new DessertMenu { DessertName = "New York Cheesecake", DessertPrice = "$6.99", IsAdd = false });
            dessertmenus.Add(new DessertMenu { DessertName = "Chocolate Lava Cake", DessertPrice = "$7.99", IsAdd = false });
            dessertmenus.Add(new DessertMenu { DessertName = "Tiramisu", DessertPrice = "$8.99", IsAdd = false });
            dessertmenus.Add(new DessertMenu { DessertName = "Apple Pie", DessertPrice = "$5.99", IsAdd = false });
            Dessert_ComboBox.ItemsSource = dessertmenus;
        }
        public class AppetizerMenu
        {
            public string AppetizerName { get; set; }
            public string AppetizerPrice { get; set; }
            public bool IsAdd { get; set; } = false;
            public int AppetizerQuantity { get; set; }

            public string Appetizer
            {
                get
                {
                    return $"{AppetizerName} - {AppetizerPrice}";
                }
            }
        }
        public class BeverageMenu
        {
            public string BeverageName { get; set; }
            public string BeveragePrice { get; set; }
            public bool IsAdd { get; set; } = false;
            public int BeverageQuantity { get; set; }

            public string Beverage
            {
                get
                {
                    return $"{BeverageName} - {BeveragePrice}";
                }
            }

        }
        public class MainCourseMenu
        {
            public string MainCourseName { get; set; }
            public string MainCoursePrice { get; set; }
            public bool IsAdd { get; set; } = false;
            public int MainCourseQuantity { get; set; }

            public string MainCourse
            {
                get
                {
                    return $"{MainCourseName} - {MainCoursePrice}";
                }
            }

        }
        public class DessertMenu
        {
            public string DessertName { get; set; }
            public string DessertPrice { get; set; }
            public bool IsAdd { get; set; } = false;
            public int DessertQuantity { get; set; }

            public string Dessert
            {
                get
                {
                    return $"{DessertName} - {DessertPrice}";
                }
            }

        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // update the DataGrid with the selected items
            List<object> selectedItems = new List<object>();
            selectedItems.AddRange(dessertmenus.Where(d => d.IsAdd).ToList());
            selectedItems.AddRange(appetizermenus.Where(d => d.IsAdd).ToList());
            selectedItems.AddRange(maincoursemenus.Where(d => d.IsAdd).ToList());
            selectedItems.AddRange(beveragemenus.Where(d => d.IsAdd).ToList());
            orderDataGrid.ItemsSource = selectedItems;

            // calculate the subtotal
            decimal subtotal = 0;
            foreach (var item in selectedItems)
            {
                if (item is AppetizerMenu)
                {
                    var appetizer = item as AppetizerMenu;
                    subtotal += decimal.Parse(appetizer.AppetizerPrice.Replace("$", ""));
                }
                else if (item is BeverageMenu)
                {
                    var beverage = item as BeverageMenu;
                    subtotal += decimal.Parse(beverage.BeveragePrice.Replace("$", ""));
                }
                else if (item is MainCourseMenu)
                {
                    var mainCourse = item as MainCourseMenu;
                    subtotal += decimal.Parse(mainCourse.MainCoursePrice.Replace("$", ""));
                }
                else if (item is DessertMenu)
                {
                    var dessert = item as DessertMenu;
                    subtotal += decimal.Parse(dessert.DessertPrice.Replace("$", ""));
                }
            }

            // update the subtotal TextBox
            txt_subtotal.Text = subtotal.ToString("C");

            foreach (var item in selectedItems)
            {
                if (item is AppetizerMenu)
                {
                    var appetizer = item as AppetizerMenu;
                    decimal price;

                    if (Decimal.TryParse(appetizer.AppetizerPrice.Substring(1), out price))
                    {
                        subtotal += price * appetizer.AppetizerQuantity;
                    }
                }
                else if (item is BeverageMenu)
                {
                    var beverage = item as BeverageMenu;
                    decimal price;
                    if (Decimal.TryParse(beverage.BeveragePrice.Substring(1), out price))
                    {
                        subtotal += price * beverage.BeverageQuantity;
                    }
                }
                else if (item is MainCourseMenu)
                {
                    var mainCourse = item as MainCourseMenu;
                    decimal price;
                    if (Decimal.TryParse(mainCourse.MainCoursePrice.Substring(1), out price))
                    {
                        subtotal += price * mainCourse.MainCourseQuantity;
                    }
                }
                else if (item is DessertMenu)
                {
                    var dessert = item as DessertMenu;
                    decimal price;
                    if (Decimal.TryParse(dessert.DessertPrice.Substring(1), out price))
                    {
                        subtotal += price * dessert.DessertQuantity;
                    }
                }
            }

            decimal tax = subtotal * 0.15m;
            txt_subtotal.Text = subtotal.ToString("C");
            txt_tax.Text = tax.ToString("C");


            // calculate bill total
            decimal billTotal = subtotal + tax;
            txt_billTotal.Text = billTotal.ToString("C");

        }


        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            // clear the order data grid
            orderDataGrid.ItemsSource = null;

            // clear the text boxes
            txt_subtotal.Text = "0.00$";
            txt_tax.Text = "0.00$";
            txt_billTotal.Text = "0.00$";

            // clear the selection
            foreach (var item in dessertmenus)
            {
                item.IsAdd = false;
            }
            foreach (var item in appetizermenus)
            {
                item.IsAdd = false;
            }
            foreach (var item in maincoursemenus)
            {
                item.IsAdd = false;
            }
            foreach (var item in beveragemenus)
            {
                item.IsAdd = false;
            }
        }


        private void orderDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Handle the selection changed event here
           
        }
       





    }
}
