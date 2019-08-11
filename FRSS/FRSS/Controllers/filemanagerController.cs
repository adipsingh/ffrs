﻿using Business;
using FRSS.Helpers;
using FRSS.Models;
using FRSS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FRSS.Controllers
{
    [ProjectSessionActionFilter]

    public class filemanagerController : Controller
    {

        // GET: filemanager
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult ViewFileManagerList()
        {
            try
            {
                ManageFileManager filemanager = new ManageFileManager();
                ViewBag.FileManagerList = filemanager.ManageFileManagerList;

                return View();
            }
            catch
            {
                ViewBag.Error = "Sorry, Problem in getting File Manager list";
            }
            return View();
        }

        public ActionResult OprFileManager(string id = "")
        {
            var istdate = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "India Standard Time");
            
            ManageCompMaster companyMaster = new ManageCompMaster();
            filemanagermodel objmodel = new filemanagermodel();
            ManageFileManager filemanager = new ManageFileManager();

            if (id == "")
            {
                var companyList = companyMaster.compmastersListByCustId(ProjectSession.custid);
                ViewBag.CompanyList = new SelectList(companyList, "compcode", "compname");

                var categoryList = filemanager.GetFileCategory();
                ViewBag.CategoryList = new SelectList(categoryList, "catid", "catname");
               

                //ViewBag.compfinyr = new SelectList(new List<compfinyearlist>(), "compfinid", "finyear");
                objmodel.uploadeddate1 = CommonMethod.ToDDMMYYYY(istdate);
                objmodel.filedate1 = CommonMethod.ToDDMMYYYY(istdate);
            }
            return View(objmodel);
        }
        [HttpPost]
        public ActionResult OprFileManager(filemanagermodel obj)
        {
            if (ModelState.IsValid)
            {

            }
            return null;
        }


        public ActionResult FileManager(string id = "")
        {
            var istdate = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "India Standard Time");

            filemanagermodel objmodel = new filemanagermodel();
            ManageFileManager filemanager = new ManageFileManager();

            if (id == "")
            {
                objmodel.uploadeddate1 = CommonMethod.ToDDMMYYYY(istdate);
                objmodel.filedate1 = CommonMethod.ToDDMMYYYY(istdate);

                //ViewBag.compid = new SelectList(filemanager.CompList, "compid", "compname");
                //ViewBag.compfinyr = new SelectList(new List<compfinyearlist>(), "compfinid", "finyear");

                //ViewBag.filecatlist = new SelectList(filemanager.FileCatList, "catid", "catname");
                //ViewBag.filesubcat = new SelectList(new List<mstfilesubcategory>(), "subcatid", "subcatname");
            }
            return View(objmodel);
        }

        [HttpGet]
        public ActionResult GetCompany()
        {
            try
            {
                ManageFileManager filemanager = new ManageFileManager();
                var data = filemanager.GetCompany();
                return new ReplyFormat().Success(Message.SUCCESS, data);
            }
            catch (Exception ex)
            {
                return new ReplyFormat().Error(ex.Message.ToString());
            }
        }

        [HttpGet]
        public ActionResult GetFinicialYearByCompanyId()
        {
            try
            {
                ManageFileManager filemanager = new ManageFileManager();
                var data = filemanager.GetCompany();
                return new ReplyFormat().Success(Message.SUCCESS, data);
            }
            catch (Exception ex)
            {
                return new ReplyFormat().Error(ex.Message.ToString());
            }
        }

        [HttpGet]
        public ActionResult GetFileCategory()
        {
            try
            {
                ManageFileManager filemanager = new ManageFileManager();
                var data = filemanager.GetFileCategory();
                return new ReplyFormat().Success(Message.SUCCESS, data);
            }
            catch (Exception ex)
            {
                return new ReplyFormat().Error(ex.Message.ToString());
            }
        }

        [HttpGet]
        public ActionResult GetFileSubCategory(int catid)
        {
            try
            {
                ManageFileManager filemanager = new ManageFileManager();
                var data = filemanager.GetFileSubCategory(catid);
                return new ReplyFormat().Success(Message.SUCCESS, data);
            }
            catch (Exception ex)
            {
                return new ReplyFormat().Error(ex.Message.ToString());
            }
        }

        [HttpPost]
        public ActionResult FileManager(filemanagermodel objmodel)
        {
            try
            {
                ManageFileManager filemanager = new ManageFileManager();
                string strRet = "Please check entered details. Something wrong with that";

                if (ModelState.IsValid)
                {

                }
                else
                {
                    var istdate = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, TimeZoneInfo.Local.Id, "India Standard Time");

                    objmodel.uploadeddate1 = CommonMethod.ToDDMMYYYY(istdate);
                    objmodel.filedate1 = CommonMethod.ToDDMMYYYY(istdate);

                    ViewBag.compid = new SelectList(filemanager.CompList, "compid", "compname");
                    ViewBag.compfinyr = new SelectList(new List<compfinyearlist>(), "compfinid", "finyear");

                    ViewBag.filecatlist = new SelectList(filemanager.FileCatList, "catid", "catname");
                    ViewBag.filesubcat = new SelectList(new List<mstfilesubcategory>(), "subcatid", "subcatname");
                }
            }
            catch
            {
                ViewBag.Error = "Sorry,Detail is not inserted";
            }
            return View(objmodel);
        }

        [HttpPost]
        public ActionResult SaveFileManager(string fileid, string compid, string compfinid,
                string filecode,
                string filecatid,
                string filesubcatid,
                string filetitle,
                DateTime uploadeddate,
                DateTime filedate,
                string filedescr, string files)
        {
            try
            {


                return new ReplyFormat().Success(Message.SUCCESS, fileid);
            }
            catch (Exception ex)
            {
                return new ReplyFormat().Error(ex.Message.ToString());
            }
        }


        [HttpPost]
        public ActionResult SaveFile(string file, string filename, int fileId)
        {
            try
            {
                //fileManagerrepo.SaveFile(file, filename, fileId);
                return new ReplyFormat().Success(Message.SUCCESS);
            }
            catch (Exception ex)
            {
                return new ReplyFormat().Error(ex.Message.ToString());
            }
        }

        [HttpGet]
        public JsonResult GetJsonFileSubCategory(int id)
        {
            ManageFileManager filemanager = new ManageFileManager();
            var data = filemanager.GetFileSubCategory(id);
            var displlist = data.Select(m => new SelectListItem()
            {
                Text = m.subcatname,
                Value = m.subcatid.ToString()
            });

            return Json(displlist, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetJsonCompFinYear(string id)
        {
            ManageFileManager filemanager = new ManageFileManager();
            var data = filemanager.GetCompFinYear(id);
            var displlist = data.Select(m => new SelectListItem()
            {
                Text = m.finyear,
                Value = m.compfinid.ToString()
            });

            return Json(displlist, JsonRequestBehavior.AllowGet);
        }
    }
}