using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    internal class TodoModel: INotifyPropertyChanged
    {
        private bool _isDone;
        private string _text;

        public DateTime CreationDate { get; set; } = DateTime.Now;

		public bool isDone
		{
			get { return _isDone; }
			set 
			{
				if (_isDone == value)         // if doesn't change than do nothing 
                    return;
				_isDone = value;
				OnPropertyChanged("IsDone");   // if something changed 
			}
		}
		public string Text
		{
			get { return _text; }
			set 
			{
				if (_text == value)
					return;
				_text = value;
				OnPropertyChanged("Text");
			}
		}

        public event PropertyChangedEventHandler? PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));		// check null? 
		}
    }
}
