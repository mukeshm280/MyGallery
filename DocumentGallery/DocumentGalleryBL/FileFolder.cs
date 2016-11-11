﻿using Siemens.iPort.EntityLite;
using System;
using System.Web;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DocumentGalleryEntity;

namespace DocumentGalleryBL
{
    public class FileFolder : EntityManager
    {
        public long UpdateFileFolder(long id,string name, string type,string action,long? status_Id)
        {
            string fileUrl = string.Empty;
            string spName = "UPDATE_FILE_FOLDER";
            ParameterCollection parameters = new ParameterCollection();
            parameters.Add(new SqlParameter("@Id", id));
            parameters.Add(new SqlParameter("@Name", name));
            parameters.Add(new SqlParameter("@Type", type));
            parameters.Add(new SqlParameter("@Action", action));
            parameters.Add(new SqlParameter("@Status_Id", status_Id));
            return Convert.ToInt32( this.ExecuteProcedure(spName, parameters));
        }
    }
}