using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace iOSNewsApp
{
	public class LoadRSSVnexpress
	{
		public string Title { get; private set; }
		public string Link { get; private set; }
		public string Description { get; private set; }
		public string Generator { get; private set; }
		public string PubDate { get; private set; }

		public List<RSSModel> items = new List<RSSModel>();

		public LoadRSSVnexpress(string url)
		{
			LoadData(url);
		}

		private void LoadData(string url)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(url);

			XmlElement channel = doc["rss"]["channel"];
			XmlNodeList itemsXml = channel.GetElementsByTagName("item");
			Title = channel["title"].InnerText;
			Link = channel["link"].InnerText;
			Description = channel["description"].InnerText;
			Generator = channel["generator"].InnerText;
			PubDate = channel["pubDate"].InnerText;

			foreach (XmlNode item in itemsXml)
			{
				RSSModel rssItem = new RSSModel();
				rssItem.Title = item["title"].InnerText;
				rssItem.Description = item["description"].InnerText;
				rssItem.Link = item["link"].InnerText;
				rssItem.PubDate = item["pubDate"].InnerText;
				items.Add(rssItem);
			}
		}
	}
}
