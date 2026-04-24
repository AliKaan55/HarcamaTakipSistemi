using HarcamaTakip.Business.Concrete;
using HarcamaTakip.DataAccess.EntityFramework;
using HarcamaTakip.Entities.Concrete;

namespace HarcamaTakip.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadExpenses();

            var expenseDal = new EfExpenseDal();
            var expenseManager = new ExpenseManager(expenseDal);

            try
            {
                var yeniHarcama = new Expense
                {
                    Description = "Form Test Harcamasý",
                    Amount = 120.00m,
                    CategoryName = "Test",
                    Date = DateTime.Now
                };

                expenseManager.Add(yeniHarcama);
                MessageBox.Show("Veritabanýna baþarýyla kaydedildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void LoadExpenses()
        {
            var expenseDal = new EfExpenseDal();
            var expenseManager = new ExpenseManager(expenseDal);


            dgvExpenses.DataSource = expenseManager.GetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var expenseDal = new EfExpenseDal();
            var expenseManager = new ExpenseManager(expenseDal);

            try
            {

                var yeniHarcama = new Expense
                {
                    Description = txtDescription.Text,

                    Amount = decimal.Parse(txtAmount.Text),
                    CategoryName = txtCategory.Text,
                    Date = DateTime.Now
                };


                expenseManager.Add(yeniHarcama);

                MessageBox.Show("Harcama baþarýyla veritabanýna kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtDescription.Clear();
                txtAmount.Clear();
                txtCategory.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadExpenses();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            var expenseDal = new EfExpenseDal();
            var expenseManager = new ExpenseManager(expenseDal);

            try
            {
               
                if (dgvExpenses.CurrentRow != null)
                {
                    
                    var selectedExpense = (Expense)dgvExpenses.CurrentRow.DataBoundItem;

                    
                    DialogResult result = MessageBox.Show($"'{selectedExpense.Description}' harcamasýný silmek istediðinize emin misiniz?",
                        "Silme Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        
                        expenseManager.Delete(selectedExpense);

                        MessageBox.Show("Harcama baþarýyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        dgvExpenses.DataSource = expenseManager.GetAll();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediðiniz bir satýrý listeden seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme iþlemi sýrasýnda hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
