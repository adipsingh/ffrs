﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Business
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class frssdbEntities : DbContext
    {
        public frssdbEntities()
            : base("name=frssdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<abcmmxyz> abcmmxyzs { get; set; }
        public virtual DbSet<bankmicrcode> bankmicrcodes { get; set; }
        public virtual DbSet<compfinyear> compfinyears { get; set; }
        public virtual DbSet<compmaster> compmasters { get; set; }
        public virtual DbSet<compuserright> compuserrights { get; set; }
        public virtual DbSet<emailsetting> emailsettings { get; set; }
        public virtual DbSet<filemanager> filemanagers { get; set; }
        public virtual DbSet<filemanagerdtl> filemanagerdtls { get; set; }
        public virtual DbSet<mstchallandown> mstchallandowns { get; set; }
        public virtual DbSet<mstcombo> mstcomboes { get; set; }
        public virtual DbSet<mstfilecategory> mstfilecategories { get; set; }
        public virtual DbSet<mstfilesubcategory> mstfilesubcategories { get; set; }
        public virtual DbSet<userinfo> userinfoes { get; set; }
        public virtual DbSet<userlog> userlogs { get; set; }
        public virtual DbSet<usermaster> usermasters { get; set; }
        public virtual DbSet<compfinyearlist> compfinyearlists { get; set; }
        public virtual DbSet<compmasterlist> compmasterlists { get; set; }
        public virtual DbSet<filemanagercomplist> filemanagercomplists { get; set; }
        public virtual DbSet<filemanagerlist> filemanagerlists { get; set; }
        public virtual DbSet<userinfolist> userinfolists { get; set; }
        public virtual DbSet<usermasterlist> usermasterlists { get; set; }
    
        public virtual ObjectResult<sp_savecompmaster_Result> sp_savecompmaster(Nullable<int> p_mode, string p_compid, string p_compcode, string p_compname, string p_compaddr1, string p_compaddr2, string p_compaddr3, string p_compcity, Nullable<long> p_compzip, string p_compstate, string p_compcontry, Nullable<long> p_compstdcode, Nullable<long> p_compphone, Nullable<long> p_compmobile1, Nullable<long> p_compmobile2, string p_compweb, string p_compemail, Nullable<long> p_compstatecode, string p_compgstno, string p_comppanno, string p_custid, string p_addedby, ObjectParameter p_errorcode, ObjectParameter p_errormessage, ObjectParameter p_respid)
        {
            var p_modeParameter = p_mode.HasValue ?
                new ObjectParameter("p_mode", p_mode) :
                new ObjectParameter("p_mode", typeof(int));
    
            var p_compidParameter = p_compid != null ?
                new ObjectParameter("p_compid", p_compid) :
                new ObjectParameter("p_compid", typeof(string));
    
            var p_compcodeParameter = p_compcode != null ?
                new ObjectParameter("p_compcode", p_compcode) :
                new ObjectParameter("p_compcode", typeof(string));
    
            var p_compnameParameter = p_compname != null ?
                new ObjectParameter("p_compname", p_compname) :
                new ObjectParameter("p_compname", typeof(string));
    
            var p_compaddr1Parameter = p_compaddr1 != null ?
                new ObjectParameter("p_compaddr1", p_compaddr1) :
                new ObjectParameter("p_compaddr1", typeof(string));
    
            var p_compaddr2Parameter = p_compaddr2 != null ?
                new ObjectParameter("p_compaddr2", p_compaddr2) :
                new ObjectParameter("p_compaddr2", typeof(string));
    
            var p_compaddr3Parameter = p_compaddr3 != null ?
                new ObjectParameter("p_compaddr3", p_compaddr3) :
                new ObjectParameter("p_compaddr3", typeof(string));
    
            var p_compcityParameter = p_compcity != null ?
                new ObjectParameter("p_compcity", p_compcity) :
                new ObjectParameter("p_compcity", typeof(string));
    
            var p_compzipParameter = p_compzip.HasValue ?
                new ObjectParameter("p_compzip", p_compzip) :
                new ObjectParameter("p_compzip", typeof(long));
    
            var p_compstateParameter = p_compstate != null ?
                new ObjectParameter("p_compstate", p_compstate) :
                new ObjectParameter("p_compstate", typeof(string));
    
            var p_compcontryParameter = p_compcontry != null ?
                new ObjectParameter("p_compcontry", p_compcontry) :
                new ObjectParameter("p_compcontry", typeof(string));
    
            var p_compstdcodeParameter = p_compstdcode.HasValue ?
                new ObjectParameter("p_compstdcode", p_compstdcode) :
                new ObjectParameter("p_compstdcode", typeof(long));
    
            var p_compphoneParameter = p_compphone.HasValue ?
                new ObjectParameter("p_compphone", p_compphone) :
                new ObjectParameter("p_compphone", typeof(long));
    
            var p_compmobile1Parameter = p_compmobile1.HasValue ?
                new ObjectParameter("p_compmobile1", p_compmobile1) :
                new ObjectParameter("p_compmobile1", typeof(long));
    
            var p_compmobile2Parameter = p_compmobile2.HasValue ?
                new ObjectParameter("p_compmobile2", p_compmobile2) :
                new ObjectParameter("p_compmobile2", typeof(long));
    
            var p_compwebParameter = p_compweb != null ?
                new ObjectParameter("p_compweb", p_compweb) :
                new ObjectParameter("p_compweb", typeof(string));
    
            var p_compemailParameter = p_compemail != null ?
                new ObjectParameter("p_compemail", p_compemail) :
                new ObjectParameter("p_compemail", typeof(string));
    
            var p_compstatecodeParameter = p_compstatecode.HasValue ?
                new ObjectParameter("p_compstatecode", p_compstatecode) :
                new ObjectParameter("p_compstatecode", typeof(long));
    
            var p_compgstnoParameter = p_compgstno != null ?
                new ObjectParameter("p_compgstno", p_compgstno) :
                new ObjectParameter("p_compgstno", typeof(string));
    
            var p_comppannoParameter = p_comppanno != null ?
                new ObjectParameter("p_comppanno", p_comppanno) :
                new ObjectParameter("p_comppanno", typeof(string));
    
            var p_custidParameter = p_custid != null ?
                new ObjectParameter("p_custid", p_custid) :
                new ObjectParameter("p_custid", typeof(string));
    
            var p_addedbyParameter = p_addedby != null ?
                new ObjectParameter("p_addedby", p_addedby) :
                new ObjectParameter("p_addedby", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_savecompmaster_Result>("sp_savecompmaster", p_modeParameter, p_compidParameter, p_compcodeParameter, p_compnameParameter, p_compaddr1Parameter, p_compaddr2Parameter, p_compaddr3Parameter, p_compcityParameter, p_compzipParameter, p_compstateParameter, p_compcontryParameter, p_compstdcodeParameter, p_compphoneParameter, p_compmobile1Parameter, p_compmobile2Parameter, p_compwebParameter, p_compemailParameter, p_compstatecodeParameter, p_compgstnoParameter, p_comppannoParameter, p_custidParameter, p_addedbyParameter, p_errorcode, p_errormessage, p_respid);
        }
    
        public virtual ObjectResult<spl_getcompmasterlist_Result> spl_getcompmasterlist(string p_custid, ObjectParameter p_errorcode, ObjectParameter p_errormessage)
        {
            var p_custidParameter = p_custid != null ?
                new ObjectParameter("p_custid", p_custid) :
                new ObjectParameter("p_custid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spl_getcompmasterlist_Result>("spl_getcompmasterlist", p_custidParameter, p_errorcode, p_errormessage);
        }
    
        public virtual ObjectResult<spl_getcompmasterlistbyid_Result> spl_getcompmasterlistbyid(string p_compid, string p_custid, ObjectParameter p_errorcode, ObjectParameter p_errormessage)
        {
            var p_compidParameter = p_compid != null ?
                new ObjectParameter("p_compid", p_compid) :
                new ObjectParameter("p_compid", typeof(string));
    
            var p_custidParameter = p_custid != null ?
                new ObjectParameter("p_custid", p_custid) :
                new ObjectParameter("p_custid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spl_getcompmasterlistbyid_Result>("spl_getcompmasterlistbyid", p_compidParameter, p_custidParameter, p_errorcode, p_errormessage);
        }
    }
}
