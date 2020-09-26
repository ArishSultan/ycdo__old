namespace DAL
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;

    //public class SalesRepDAL
    //{
    //    private EmployeeAsSaleRep employeasaleRep;
    //    private SalesPerson employee;
    //    private List<SalesPerson> employees;

    //    public List<SalesPerson> GetSaleRep()
    //    {
    //        try
    //        {


    //            employeasaleRep = new EmployeeAsSaleRep();
    //            if (employeasaleRep.ExportEmployeeAsSaleRep() == true)
    //            {
    //                employees = new List<SalesPerson>();
    //                XElement xe = XElement.Load(employeasaleRep.FileNameXML);
    //                var empElement = from el in xe.Elements("PAW_Employee")
    //                                 select el;
    //                foreach (var el in empElement)
    //                {
    //                    if (el.Element("isSalesRep").Value == "TRUE")
    //                    {
    //                        employee = new SalesPerson();
    //                        employee.Id = el.Element("ID").Value;
    //                        employee.Name = el.Element("Name") == null ? "" : el.Element("Name").Value;
    //                        employee.Guid = el.Element("EmployeeGUID").Value;
    //                        employee.EmployeeType = EmployeeType.SalesRep;
                            
    //                        if (el.Element("isInactive").Value == "TRUE")
    //                            employee.IsInActive = true;

    //                        employees.Add(employee);
    //                    }
    //                }
    //            }
    //            return employees;
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show(ex.Message, "GetSaleRep");
    //            return employees;
    //        }
    //    }
    //}
}

