using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CaseDemo.MultipleSubuser.ViewModel
{
    public class Profiler
    {
        public List<ProfilerViewModel> profilerViewModels { get; set; }
        public Profiler()
        {

            profilerViewModels = new List<ProfilerViewModel>();
            profilerViewModels.Add(new ProfilerViewModel
            {
                Name = "Sub User1",
                Detail1 = "User1Details1",
                Detail2 = "User1Details2",
                Detail3 = "User1Details3",
                Detail4 = "User1Details4"

            });
            profilerViewModels.Add(new ProfilerViewModel
            {
                Name = "Sub User2",
                Detail1 = "User2Details1",
                Detail2 = "User2Details2",
                Detail3 = "User2Details3",
                Detail4 = "User2Details4"

            });
            profilerViewModels.Add(new ProfilerViewModel
            {
                Name = "Sub User3",
                Detail1 = "User3Details1",
                Detail2 = "User3Details2",
                Detail3 = "User3Details3",
                Detail4 = "User3Details4"

            });
            profilerViewModels.Add(new ProfilerViewModel
            {
                Name = "Sub User4",
                Detail1 = "User4Details1",
                Detail2 = "User4Details2",
                Detail3 = "User4Details3",
                Detail4 = "User4Details4"

            });

        }
    }
}
