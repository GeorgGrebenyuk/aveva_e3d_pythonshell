using System.Windows.Documents;
using Teigha.DatabaseServices;
using Teigha.Runtime;

using CADCommandsNRX;

using System;

namespace CADCommands
{
    public class AuxiliaryCommands : IExtensionApplication
    {
        public static void InsertToDrawing (dynamic entity)
        {
            dynamic native_data = entity.UnmanagedObject;
            CADCommandsNRX.AuxiliaryTools.CreateObject(native_data);
        }

        public static void InsertToDrawing2(dynamic entity, Transaction tr, BlockTableRecord btr)
        {
            Circle c = (Circle)entity;
            btr.AppendEntity(c);
            tr.AddNewlyCreatedDBObject(c, true);
            //var native_data = entity.UnmanagedObject;
            //CADCommandsNRX.AuxiliaryTools.CreateObject(native_data);
        }

        public static object OpenModeRead
        {
            
            get
            {
                return OpenMode.ForRead;
            }
        }
        public static object OpenModeWrite
        {
            get
            {
                return OpenMode.ForWrite;
            }
        }
        public static object OpenModeNotify
        {
            get
            {
                return OpenMode.ForNotify;
            }
        }

        public void Initialize()
        {
            //throw new System.NotImplementedException();
        }

        public void Terminate()
        {
            //throw new System.NotImplementedException();
        }
    }
}