/*Bam Bohara
 * ITSE 1430
 * Lab4
 */
using System;
using System.Windows.Forms;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;

namespace Nile.Windows
{
  public partial class MainForm : Form
    {
        #region Construction

  public MainForm()
        {
            InitializeComponent();
            aboutToolStripMenuItem.Click += OnAboutBoxAdd;

         }
        #endregion

  protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _gridProducts.AutoGenerateColumns = false;

            UpdateList();
        }

        #region Event Handlers
        
  private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

  private void OnProductAdd( object sender, EventArgs e )
        {
            var child = new ProductDetailForm("Product Details");
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Handle errors
            try
            {
                _database.Add(child.Product);
            } catch (Exception ex)
            {
                MessageBox.Show("Product could not be added.",ex.ToString());
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            };

            //Save product

            UpdateList();
          }

        private void OnProductEdit( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("No products available.");
                return;
            };

            EditProduct(product);
        }        

        private void OnProductDelete( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
                return;

            DeleteProduct(product);
        }        
                
        private void OnEditRow( object sender, DataGridViewCellEventArgs e )
        {
            var grid = sender as DataGridView;

            //Handle column clicks
            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as Product;

            if (item != null)
                EditProduct(item);
        }

        private void OnKeyDownGrid( object sender, KeyEventArgs e )
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var product = GetSelectedProduct();
            if (product != null)
                DeleteProduct(product);
			
			//Don't continue with key
            e.SuppressKeyPress = true;
        }

        #endregion

        #region Private Members

        private void DeleteProduct ( Product product )
        {
            //Confirm
            if (MessageBox.Show(this, $"Are you sure you want to delete '{product.Name}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //TODO: Handle errors
            try
            {
                _database.Remove(product.Id);
            } catch (Exception ex)
            {
                MessageBox.Show("Product could not be deleted", ex.ToString());

            };

            //Delete product
            
            UpdateList();
        }

        private void EditProduct ( Product product )
        {
            var child = new ProductDetailForm("Product Details");
            child.Product = product;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Handle errors
            try
            {
            _database.Update(child.Product);

            } catch (Exception ex)
            {
               MessageBox.Show("Product could not be updated",ex.ToString());

            };
            //Save product
            
            UpdateList();
        }

        private Product GetSelectedProduct ()
        {
            if (_gridProducts.SelectedRows.Count > 0)
                return _gridProducts.SelectedRows[0].DataBoundItem as Product;

            return null;
        }

        private void UpdateList ()
        {
            //TODO: Handle errors
            try
            {
                //_bsProducts.DataSource = _database.GetAll();
                var items = _database.GetAll()
                              .OrderBy(x => x.Name)
                              .Select(x => x)  
                              .ToArray();
                _bsProducts.DataSource  = items;


            } catch (Exception ex)
            {
              // MessageBox.Show("Product list could not be updated");
            };
            }
         private static string s_connectionString = ConfigurationManager.ConnectionStrings["ProductDatabase"].ConnectionString;
         private IProductDatabase _database = new Stores.Sql.SqlProductDatabase(s_connectionString);
       // private IProductDatabase _database = new Nile.Stores.MemoryProductDatabase();
       



        
        #endregion

  private void _mainMenu_ItemClicked ( object sender, ToolStripItemClickedEventArgs e )
        {

        }
  private void OnAboutBoxAdd ( object sender, EventArgs e )
        {
            var form = new AboutBox();

            var result = form.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
         }

     }
 }
