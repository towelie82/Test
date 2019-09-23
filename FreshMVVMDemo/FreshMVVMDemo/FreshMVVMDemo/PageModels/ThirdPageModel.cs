using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FreshMVVMDemo.PageModels
{
    public class ThirdPageModel:FreshBasePageModel
    {
        #region Default Override functions
        public override void Init(object initData)
        {
            base.Init(initData);
        }

        public override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
        }

        protected override void ViewIsDisappearing(object sender, EventArgs e)
        {
            base.ViewIsDisappearing(sender, e);
        }
        #endregion


        #region Commands
        public Command GoBackSecondCommand
        {
            get
            {
                return new Command(async () =>
                {
                    //await CoreMethods.PopPageModel();  //go back to main page
                    await CoreMethods.PushPageModel<SecondPageModel>(); //Go back to third page
                });
            }
        }
        #endregion


    }
}
