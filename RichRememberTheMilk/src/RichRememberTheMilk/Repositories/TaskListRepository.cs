﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RichRememberTheMilk.ViewModel;
using TinyMVVM.Repositories;
using TinyMVVM.Specifications;

namespace RichRememberTheMilk.Desktop.Repositories
{
    public class TaskListRepository : IRepository<TaskList>
    {
        public IEnumerable<TaskList> Get()
        {
            return Get(new AllSpecification<TaskList>());
        }

        public IEnumerable<TaskList> Get(ISpecification<TaskList> spec)
        {
                        //Note: Test data is generated by Alex York
            var inboxList = new TaskList { Name = "Inbox" };
            inboxList.Tasks.Add(new Task { Description = "Buy milk" });
            inboxList.Tasks.Add(new Task { Description = "Find a hot blonde Norwegian girl" });
            inboxList.Tasks.Add(new Task { Description = "Find another hot blonde Norwegian girl" });

            var workList = new TaskList { Name = "Work" };
            workList.Tasks.Add(new Task { Description = "Steal milk from work to bring home" });

            var personalList = new TaskList() {Name = "Personal"};

            var lists = new List<TaskList>();
            lists.Add(inboxList);
            lists.Add(workList);
            //lists.Add(personalList);
            return lists;
        }
    }
}
