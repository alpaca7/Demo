using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly:Autodesk.AutoCAD.Runtime.CommandClass(typeof(Demo.Class1))]
namespace Demo
{
    public class Class1
    {
        [Autodesk.AutoCAD.Runtime.CommandMethod("tool1")]
        public void Tool1()
        {
            Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage("Hello World");
        }
        [Autodesk.AutoCAD.Runtime.CommandMethod("tool2")]
        public void Tool2()
        {
            Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage("Hello World");
        }
    }
}
