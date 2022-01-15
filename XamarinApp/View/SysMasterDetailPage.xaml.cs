﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SysMasterDetailPage : MasterDetailPage
	{
		public SysMasterDetailPage()
		{
			InitializeComponent();

			Detail = new NavigationPage(new MstPage1());
			IsPresented = false;
		}

		private void BtnMasterFile_Clicked(object sender, EventArgs e)
		{

		}

		private void BtnTransaction_Clicked(object sender, EventArgs e)
		{
			Detail = new NavigationPage(new TrnNoteListPage());
			IsPresented = false;
		}

		private void BtnReport_Clicked(object sender, EventArgs e)
		{

		}

		private void BtnSetting_Clicked(object sender, EventArgs e)
		{

		}

		private void BtnUtilities_Clicked(object sender, EventArgs e)
		{

		}

		private void BtnAbout_Clicked(object sender, EventArgs e)
		{
			Detail = new NavigationPage(new MstPage1());
			IsPresented = false;
		}
	}
}
