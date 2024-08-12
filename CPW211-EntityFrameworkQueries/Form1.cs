using CPW211_EntityFrameworkQueries.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace CPW211_EntityFrameworkQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectAllVendors_Click(object sender, EventArgs e)
        {
            using ApContext dbContext = new ApContext();

            // LINQ (language Integrated Query) method syntax
            List<Vendor> vendorList = dbContext.Vendors.ToList();

            // LINQ query syntax 
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                        select v).ToList();
        }

        private void btnAllCaliforniaVendors_Click(object sender, EventArgs e)
        {
            using ApContext dbContext = new();

            List<Vendor> vendorList = dbContext.Vendors
                                        .Where(v => v.VendorState == "CA")
                                        .OrderBy(v => v.VendorName)
                                        .ToList();
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                        where v.VendorState == "CA"
                                        orderby v.VendorName
                                        select v).ToList();
        }

        private void btnSelectSpecificColumns_Click(object sender, EventArgs e)
        {
            ApContext dbContext = new();
            // Anonymous type
            List<VendorLocation> results = (from v in dbContext.Vendors
                                            select new VendorLocation
                                            {
                                                VendorName = v.VendorName,
                                                VendorState = v.VendorState,
                                                VendorCity = v.VendorCity
                                            }).ToList();
            StringBuilder displayString = new();
            foreach (VendorLocation vendor in results)
            {
                displayString.AppendLine($"{vendor.VendorName} is in {vendor.VendorCity}");
            }

            MessageBox.Show(displayString.ToString());
        }

        private void btnMiscQueries_Click(object sender, EventArgs e)
        {
            ApContext dbContext = new();

            // Check if a Vendor exist in WA
            bool doesExist = (from v in dbContext.Vendors
                              where v.VendorState == "WA"
                              select v).Any();

            // Get number of Invoices
            int invoiceCount = (from invoices in dbContext.Invoices
                                select invoices).Count();

            //Query a single vendor
            Vendor? singleVendor = (from v in dbContext.Vendors
                                    where v.VendorName == "IBM"
                                    select v).SingleOrDefault();
            if (singleVendor != null)
            {
                //Do something with the Vendor object
            }
        }

        private void btnVendorsAndInvoices_Click(object sender, EventArgs e)
        {
            ApContext dbContext = new();

            //Vendors left join invoices
            List<Vendor> allVendors = dbContext.Vendors.Include(v => v.Invoices).ToList();

            //unfinished code this pulls vendor object for each individual invoice
            //Vendors are pulled back if they have no invoices
/*            List<Vendor> allVendors = (from v in dbContext.Vendors
                                      join inv in dbContext.Invoices
                                        on v.VendorId equals inv.VendorId into grouping
                                      from inv in grouping.DefaultIfEmpty()
                                      select v).ToList();*/

            StringBuilder results = new();

            foreach (Vendor v in allVendors)
            {
                results.Append(v.VendorName);
                foreach (Invoice inv in v.Invoices)
                {
                    results.Append(", " + inv.InvoiceNumber);
                }
                results.AppendLine();
            }
            MessageBox.Show(results.ToString());
        }
    }

    class VendorLocation
    {
        public string VendorName { get; set; }

        public string VendorState { get; set; }

        public string VendorCity { get; set; }

    }
}










