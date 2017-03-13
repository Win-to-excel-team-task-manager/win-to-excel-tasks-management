using System.Collections.Generic;
using TasksManager.Entities;

namespace TasksManager.DAL
{
    public interface IEtityDAO
    {
        /// <summary>
        /// File Name
        /// </summary>
        string FileFullPath { set; get; }


        List<BaseEntity> GetData();
    }
}