using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAttendance.Controllers
{
    
    public class HomeController : Controller
    {
        database_studentContainer context = new database_studentContainer();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Student_Details()
        {            
            return View(context.Student_Details.ToList());
        }

        public ActionResult Student_Details_filter(string section_search)
        {
            ViewBag.section = section_search;
            return View(context.Student_Details.Where(r => r.Section == section_search).ToList());
        }

        public ActionResult Student_Details_filter_filter(Absent_swami emp, string sections)
        {
            CreatAbsents_swami_forfilter_post(emp,sections);
            return View(context.Student_Details.Where(r => r.Section == sections).ToList());
        }

        public ActionResult CreatStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatStudent(Student_Details emp)
        {
            if (ModelState.IsValid)
            {
                context.Student_Details.Add(emp);
                context.SaveChanges();
                return RedirectToAction("Student_Details");
            }
            return View();
        }

        public ActionResult AbsentsDetails()
        {
            return View(context.Absent_swami.ToList());
        }
        public ActionResult CreatAbsents(int id)
        {

            var a = context.Student_Details.Single(emp => emp.id == id);
            var Member_id = a.Member_id.ToString();
            var Name = a.Name.ToString();
            var Branch = a.Branch.ToString();
            var section = a.Section.ToString();
            var house = a.House.ToString();

            ViewBag.mid = Member_id.ToString();
            ViewBag.name = Name.ToString();
            ViewBag.branch = Branch.ToString();
            ViewBag.section = section.ToString();
            ViewBag.house = house.ToString();            
            return View();
        }

        [HttpPost]
        public ActionResult CreatAbsents(Absent emp)
        {
            if (ModelState.IsValid)
            {
                context.Absents.Add(emp);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();            
        }
         public ActionResult CreatAbsents_o(int id)
        {

            var a = context.Student_Details.Single(emp => emp.id == id);
            var Member_id = a.Member_id.ToString();
            var Name = a.Name.ToString();
            var Branch = a.Branch.ToString();
            var section = a.Section.ToString();
            var house = a.House.ToString();

            ViewBag.mid = Member_id.ToString();
            ViewBag.name = Name.ToString();
            ViewBag.branch = Branch.ToString();
            ViewBag.section = section.ToString();
            ViewBag.house = house.ToString();            
            return View();
        }

        [HttpPost]
        public ActionResult CreatAbsents_o(Absent emp)
        {
            if (ModelState.IsValid)
            {
                context.Absents.Add(emp);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();            
        }


        public ActionResult CreatAbsents_swami(int id)
        {

            var a = context.Student_Details.Single(emp => emp.id == id);
            var Member_id = a.Member_id.ToString();
            var Name = a.Name.ToString();
            var Branch = a.Branch.ToString();
            var section = a.Section.ToString();
            var house = a.House.ToString();

            ViewBag.mid = Member_id.ToString();
            ViewBag.name = Name.ToString();
            ViewBag.branch = Branch.ToString();
            ViewBag.section = section.ToString();
            ViewBag.house = house.ToString();
            return View();
        }

        [HttpPost]
        public ActionResult CreatAbsents_swami(Absent_swami emp)
        {
            if (ModelState.IsValid)
            {
                context.Absent_swami.Add(emp);
                context.SaveChanges();
                return RedirectToAction("Student_Details");
            }
            return View();
        }



        public ActionResult CreatAbsents_swami_forfilter(int id)
        {

            var a = context.Student_Details.Single(emp => emp.id == id);
            var Member_id = a.Member_id.ToString();
            var Name = a.Name.ToString();
            var Branch = a.Branch.ToString();
            var section = a.Section.ToString();
            var house = a.House.ToString();

            ViewBag.mid = Member_id.ToString();
            ViewBag.name = Name.ToString();
            ViewBag.branch = Branch.ToString();
            ViewBag.section = section.ToString();
            ViewBag.house = house.ToString();
            return View();
        }

        
        public void CreatAbsents_swami_forfilter_post(Absent_swami emp,string sections)
        {
            ViewBag.section_post = sections;
            
            if (ModelState.IsValid)
            {
                ViewBag.section = emp.Section;         
                context.Absent_swami.Add(emp);
                context.SaveChanges();               
            }
           
        }


      













        public ActionResult Delete_Absent(int id)
        {
            
             Absent_swami qwert =  context.Absent_swami.Find(id);
            context.Absent_swami.Remove(qwert);
            context.SaveChanges();
            return RedirectToAction("AbsentsDetails");
        }


    }
}