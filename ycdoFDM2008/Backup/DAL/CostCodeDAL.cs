namespace DAL
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;

    //public class CostCodeDAL
    //{
    //    private CostCode costCode;
    //    private CostCodeList costcodeList;
    //    private List<CostCode> costCodes;

    //    public List<CostCode> GetCostCode()
    //    {
    //        try
    //        {
    //            costcodeList = new CostCodeList();
    //            if (costcodeList.ExportCostCode() == true)
    //            {
    //                costCodes = new List<CostCode>();
    //                XElement xdoc = XElement.Load(costcodeList.FileNameXML);
    //                var xcost = from el in xdoc.Elements("PAW_Cost")
    //                            select el;
    //                foreach (var el in xcost)
    //                {
    //                    costCode = new CostCode();
    //                    costCode.Id = el.Element("ID").Value;
    //                    costCode.CostType = el.Element("CostType") == null ? "" : el.Element("CostType").Value;
    //                    costCode.Description = el.Element("Description") == null ? "" : el.Element("Description").Value;
    //                    costCodes.Add(costCode);
    //                }
    //            }
    //            return costCodes;
    //        }
    //        catch (Exception ex)
    //        {

    //            MessageBox.Show(ex.Message, "GetCostCode");
    //            return costCodes;
    //        }
    //    }
    //}

}

