using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace DANHOM.Module.QLCuaHangPB
{
    [DefaultClassOptions]
    public partial class Khach
    {
        public Khach(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
