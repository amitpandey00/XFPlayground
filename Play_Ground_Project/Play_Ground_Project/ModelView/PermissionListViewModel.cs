using Play_Ground_Project.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Play_Ground_Project.ModelView
{
    public class PermissionListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<PermissionsPageView> _permissionsPageViews;

        public List<PermissionsPageView> PermissionsPageView
        {

            set
            {
                _permissionsPageViews = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PermissionPageView"));
            }
            get { return _permissionsPageViews; }
        }
 
        public PermissionListViewModel()
        {
            PermissionsPageView = new List<PermissionsPageView>();
            AddListView();
        }

        public void AddListView()
        {
            PermissionsPageView.Add(new PermissionsPageView
            {
                Icon="icon_phoneState.png",
                Name="phone state",
                Description="we need this permission to ensure the SIM card in your phone and your registered phone number match",
                Type="mandatory"
 
            });

            PermissionsPageView.Add(new PermissionsPageView
            {
                Icon = "icon_telephone.png",
                Name = "telephone",
                Description = "we need this permission to intelligently surface location specific rewards and alerts",
                Type = "mandatory"

            });
            PermissionsPageView.Add(new PermissionsPageView
            {
                Icon = "icon_sms.png",
                Name = "sms",
                Description = "we need this permission to activate UPI and send you credit card payment reminders to provide a seamless experience",
                Type = "mandatory"

            });
            PermissionsPageView.Add(new PermissionsPageView
            {
                Icon = "icon_callLog.png",
                Name = "call logs",
                Description = "we need this permission to intelligently surface location specific rewards and alerts",
                Type = "mandatory"

            });
            PermissionsPageView.Add(new PermissionsPageView
            {
                Icon = "icon_camera.png",
                Name = "camera",
                Description = "we need this permission to intelligently surface location specific rewards and alerts",
                Type = "mandatory"

            }); PermissionsPageView.Add(new PermissionsPageView
            {
                Icon = "icon_location.png",
                Name = "location",
                Description = "we need this permission to intelligently surface location specific rewards and alerts",
                Type = "mandatory"

            }); PermissionsPageView.Add(new PermissionsPageView
            {
                Icon = "icon_contacts.png",
                Name = "contacts",
                Description = "we need this permission to intelligently surface location specific rewards and alerts",
                Type = "mandatory"

            }); PermissionsPageView.Add(new PermissionsPageView
            {
                Icon = "icon_storage.png",
                Name = "storage",
                Description = "we need this permission to intelligently surface location specific rewards and alerts",
                Type = "mandatory"

            });
        }
    }
}

