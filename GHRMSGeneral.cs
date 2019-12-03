using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBGHRMS
{
    public enum DataXml
    {
        Id = 0,
        RoleTitle = 1,
        RoleDescription = 2,
        ForwardingDirectory = 3,
        ForwadringPage = 4,
        IsActive = 5,
        GradeTitle = 6,
        MasterPage = 7,
        ProductType = 8
    };


    //public enum USERTYPE
    //{
    //    SA = 1,
    //    GSA = 2,
    //    PayRollAdmin = 3,
    //    PayRollUser = 5,
    //    PayRollSubUser = 6,
    //    HR_User = 7,
    //    HR_Admin = 8,
    //    ClientAdmin = 9
    //}
    public enum InterViewtype
    {
        OnlineTest = 1330000013
    }

   public class General
    {
    
        
    }

   public struct FileTemplate
   {
       byte[] FileContent;
       String FileContentType;
       String FileName;
       String FileExtension;
       int FileContentLength;
       bool FileActive;

       public Byte[] File_Content
       {
           get
           {
               return FileContent;
           }
           set
           {
               FileContent = value;
           }
       }
       public int File_ContentLength
       {
           get
           {
               return FileContentLength;
           }
           set
           {
               FileContentLength = value;
           }
       }
       public String File_ContentType
       {
           get
           {
               return FileContentType;
           }
           set
           {
               FileContentType = value;
           }
       }
       public String File_Name
       {
           get
           {
               return FileName.Replace(" ", "_");
           }
           set
           {
               FileName = value;
           }
       }
       public String File_Extension
       {
           get
           {
               return FileExtension;
           }
           set
           {
               FileExtension = value;
           }
       }
       public bool File_Active
       {
           get
           {
               return FileActive;
           }
           set
           {
               FileActive = value;
           }
       }

   }
}
