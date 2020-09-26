namespace DAL
{
    using Common;
   // // using ExportImport;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Xml.Linq;

    //public class JobDAL
    //{
    //    private Job job;
    //    private JobList jobList;
    //    private List<Job> jobs;

    //    public List<Job> GetJob()
    //    {
    //        try
    //        {
    //            jobList = new JobList();
    //            if (jobList.ExportJob() == true)
    //            {
    //                jobs = new List<Job>();
    //                XElement xdoc = XElement.Load(jobList.FileNameXML);
    //                var xjob = from el in xdoc.Elements("PAW_Job")
    //                           select el;

    //                foreach (var el in xjob)
    //                {
    //                    if (el.Element("isInactive").Value == "FALSE")
    //                    {
    //                        job = new Job();
    //                        job.Id = el.Element("ID").Value;
    //                        //job.Description = el.Element("Description") == null  ? "" : el.Element("Description").Value ;
    //                        job.UsePhases = Convert.ToBoolean(el.Element("UsePhases").Value);//== false  ? false : true ;
    //                        job.GuId = el.Element("GUID").Value;

    //                        jobs.Add(job);
    //                    }

    //                }
    //            }

    //            return jobs;
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message, "GetJob");
    //            return jobs;
    //        }

    //    }

    //    public List<Job> GetJobPhaseCostCode()
    //    {
    //        try
    //        {
    //            jobList = new JobList();
    //            if (jobList.ExportJob() == true)
    //            {
    //                jobs = new List<Job>();
    //                XElement xdoc = XElement.Load(jobList.FileNameXML);
    //                var xjob = from el in xdoc.Elements("PAW_Job")
    //                           select el;
    //                PhaseDAL phase = new PhaseDAL();
    //                List<Phase> phases = phase.GetPhaseandCostCode();
    //                foreach (var el in xjob)
    //                {
    //                    if (el.Element("isInactive").Value == "FALSE")
    //                    {
    //                        job = new Job();
    //                        job.Id = el.Element("ID").Value;
    //                        //job.Description = el.Element("Description") == null  ? "" : el.Element("Description").Value ;
    //                        job.UsePhases = Convert.ToBoolean(el.Element("UsePhases").Value);//== false  ? false : true ;
    //                        job.GuId = el.Element("GUID").Value;
    //                        if (job.UsePhases == true)
    //                            job.Phases = phases;
    //                        jobs.Add(job);
    //                    }

    //                }
    //            }

    //            return jobs;
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message, "GetJobPhaseCostCode");
    //            return jobs;
    //        }

    //    }
    //}
}

