﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duality.Editor.PackageManagement
{
	public class PackageInfo
	{
		private	string			id				= null;
		private	Version			version			= null;
		private	string			title			= null;
		private	string			summary			= null;
		private	string			description		= null;
		private	Uri				projectUrl		= null;
		private	Uri				iconUrl			= null;
		private	int				downloadCount	= 0;
		private	DateTime		publishDate		= DateTime.MinValue;
		private	List<string>	authors			= new List<string>();
		private	List<string>	tags			= new List<string>();


		public string Id
		{
			get { return this.id; }
		}
		public Version Version
		{
			get { return this.version; }
		}
		public string Title
		{
			get { return this.title; }
			internal set { this.title = value; }
		}
		public string Summary
		{
			get { return this.summary; }
			internal set { this.summary = value; }
		}
		public string Description
		{
			get { return this.description; }
			internal set { this.description = value; }
		}
		public Uri ProjectUrl
		{
			get { return this.projectUrl; }
			internal set { this.projectUrl = value; }
		}
		public Uri IconUrl
		{
			get { return this.iconUrl; }
			internal set { this.iconUrl = value; }
		}
		public int DownloadCount
		{
			get { return this.downloadCount; }
			internal set { this.downloadCount = value; }
		}
		public DateTime PublishDate
		{
			get { return this.publishDate; }
			internal set { this.publishDate = value; }
		}
		public IEnumerable<string> Authors
		{
			get { return this.authors; }
			internal set { this.authors = (value ?? Enumerable.Empty<string>()).ToList(); }
		}
		public IEnumerable<string> Tags
		{
			get { return this.tags; }
			internal set { this.tags = (value ?? Enumerable.Empty<string>()).ToList(); }
		}


		internal PackageInfo(string id, Version version)
		{
			this.id = id;
			this.version = version;
		}
	}
}
