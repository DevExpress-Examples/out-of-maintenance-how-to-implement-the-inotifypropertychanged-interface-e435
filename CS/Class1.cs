using System;
using System.Collections;
using System.ComponentModel;

namespace WindowsApplication18
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	/// 
	public class Record : INotifyPropertyChanged{
		int id, age;
		string name;
        BindingList<Record> detail;
        public Record() { detail = new BindingList<Record>(); detail.AllowEdit = true; detail.AllowNew = true; }
		public Record(int id, string name, int age) {
			this.id = id;
			this.name = name;
			this.age = age;
			//this.detail = detail;
		}
		public int ID { get { return id; } }
		virtual public string Name {
			get { return name; }
			set { 
                name = value;
                NotifyPropertyChanged("Name");
            }
		}
		public int Age {
			get { return age; }
			set { 
                age = value;
                NotifyPropertyChanged("Age");
            }
		}

        public BindingList<Record> Detail {
            get { return detail; }
            set { detail = value; }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #endregion
    }

}
