using FinalProject.Composite;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.State
{
    internal abstract class SystemItemState
    {
        protected SystemItem SystemItem { get; set; }

        public SystemItemState(SystemItem systemItem)
        {
            SystemItem = systemItem;
        }
        public abstract string Merge_file(SystemItem item);
        public abstract string Merge_folder(SystemItem item);
        public abstract string Commit_file();
        public abstract string Commit_folder();
        public abstract string RequestReview();
        public abstract string UndoTheCommit_file();
        public abstract string UndoTheCommit_folder();  
        
    }
}
