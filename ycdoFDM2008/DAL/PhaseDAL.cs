namespace DAL
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;

    //public class PhaseDAL
    //{
    //    private Phase phase;
    //    private PhaseList phaseList;
    //    private List<Phase> phases;

    //    public List<Phase> GetPhaseandCostCode()
    //    {
    //        try
    //        {
    //            phaseList = new PhaseList();
    //            if (phaseList.ExportPhase() == true)
    //            {
    //                phases = new List<Phase>();
    //                XElement xdoc = XElement.Load(phaseList.FileNameXML);
    //                var xphase = from el in xdoc.Elements("PAW_Phase")
    //                             select el;
    //                CostCodeDAL costcode = new CostCodeDAL();
    //                List<CostCode> costcodes = costcode.GetCostCode();
    //                foreach (var el in xphase)
    //                {
    //                    if (el.Element("isInactive").Value == "FALSE")
    //                    {
    //                        phase = new Phase();
    //                        phase.Id = el.Element("ID").Value;
    //                        phase.Description = el.Element("Description") == null ? "" : el.Element("Description").Value;
    //                        phase.CostType = el.Element("CostType") == null ? "" : el.Element("CostType").Value;
    //                        phase.UsecostCodes = el.Element("UseCostCodes") == null ? false : true;
    //                        if (phase.UsecostCodes == true)
    //                            phase.CostCode = costcodes;
    //                        phases.Add(phase);
    //                    }

    //                }
    //            }
    //            return phases;
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message, "GetPhaseandCostCode");
    //            return phases;
    //        }
    //    }

    //    public List<Phase> GetPhaseOnly()
    //    {
    //        try
    //        {
    //            phaseList = new PhaseList();
    //            if (phaseList.ExportPhase() == true)
    //            {
    //                phases = new List<Phase>();
    //                XElement xdoc = XElement.Load(phaseList.FileNameXML);
    //                var xphase = from el in xdoc.Elements("PAW_Phase")
    //                             select el;

    //                foreach (var el in xphase)
    //                {
    //                    if (el.Element("isInactive").Value == "FALSE")
    //                    {
    //                        phase = new Phase();
    //                        phase.Id = el.Element("ID").Value;
    //                        phase.Description = el.Element("Description") == null ? "" : el.Element("Description").Value;
    //                        phase.CostType = el.Element("CostType") == null ? "" : el.Element("CostType").Value;
    //                        phase.UsecostCodes = el.Element("UseCostCodes") == null ? false : true;

    //                        phases.Add(phase);
    //                    }

    //                }
    //            }
    //            return phases;
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message, "GetPhaseOnly");
    //            return phases;
    //        }
    //    }
    //}
}

