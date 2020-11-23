using Pagination.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Pagination.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index(int? page)
        {
            int pageSize = 5;
            int pageNumber = (page ?? 1);

            return View(GetProjects().ToPagedList(pageNumber, pageSize));
        }

        private List<Project> GetProjects()
        {
            List<Project> projectsList = new List<Project>();

            Project proj1 = new Project();
            proj1.ProjectId = 1;
            proj1.ProjectName = "Project 1";
            proj1.ProjectManagerName = "Dave Ryan";
            proj1.ProjectStatus = "Production";

            projectsList.Add(proj1);

            Project proj2 = new Project();
            proj2.ProjectId = 2;
            proj2.ProjectName = "Project 2";
            proj2.ProjectManagerName = "Steve Warner";
            proj2.ProjectStatus = "Beta";

            projectsList.Add(proj2);

            Project proj3 = new Project();
            proj3.ProjectId = 3;
            proj3.ProjectName = "Project 3";
            proj3.ProjectManagerName = "Kelly Peters";
            proj3.ProjectStatus = "Development";

            projectsList.Add(proj3);

            Project proj4 = new Project();
            proj4.ProjectId = 4;
            proj4.ProjectName = "Project 4";
            proj4.ProjectManagerName = "Michelle Carpenter";
            proj4.ProjectStatus = "Production";

            projectsList.Add(proj4);

            Project proj5= new Project();
            proj5.ProjectId = 5;
            proj5.ProjectName = "Project 5";
            proj5.ProjectManagerName = "John Doe";
            proj5.ProjectStatus = "Development";

            projectsList.Add(proj5);

            Project proj6 = new Project();
            proj6.ProjectId = 6;
            proj6.ProjectName = "Project 6";
            proj6.ProjectManagerName = "Smith Ryan";
            proj6.ProjectStatus = "Beta";

            projectsList.Add(proj6);

            return projectsList;
        }

        // GET: Project/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Project/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Project/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Project/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
