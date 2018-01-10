using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GarupaCard.Shared.Models
{
    public class UserInfo
    {
        private const string userinfofile = "userinfo.json";
        public static UserInfo Instance { get; } = GetUserInfo();
        public static HttpClient Http = GetHttpClient();

        static HttpClient GetHttpClient()
        {
            var handler = new HttpClientHandler();
            handler.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            var client = new HttpClient(handler);
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate");
            client.DefaultRequestHeaders.Add("accept-language", "en-US,en;q=0.8");
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.24 Safari/537.36");
            return client;
        }
        static UserInfo GetUserInfo()
        {
            try
            {
                var json = File.ReadAllText(userinfofile, Encoding.UTF8);
                return JsonConvert.DeserializeObject<UserInfo>(json);
            }
            catch (Exception e)
            {
                return new UserInfo()
                {
                    AllCards = new List<Card>(),
                    UserCardIds = new List<int>()
                };
            }
        }
        private UserInfo()
        {
        }
        [JsonIgnore]
        public List<Card> UserCards => (
            from ac in AllCards
            join cardId in UserCardIds on ac.cardId equals cardId
            select ac
        ).ToList();

        public List<Card> AllCards { get; set; }
        public List<int> UserCardIds { get; set; }

        const string cardsapi = "https://api.bangdream.ga/v1/jp/card?limit=999&page=1&sort=desc&orderKey=cardId";

        public void Init()
        {
            if (!AllCards.Any())
            {
                UpdateUserCardsInfo();
            }

        }

        public void UpdateUserCardsInfo()
        {
            var json = Http.GetStringAsync(cardsapi).Result;
            var cards = JsonConvert.DeserializeObject<carddata>(json);
            AllCards.Clear();
            AllCards.AddRange(cards.data);
            Save();
        }


        public void AddUserCard(int cardId)
        {
            if (!UserCardIds.Contains(cardId))
                UserCardIds.Add(cardId);
        }

        public void Save()
        {
            lock (this)
            {
                File.WriteAllText(userinfofile, JsonConvert.SerializeObject(this), Encoding.UTF8);
            }
        }
    }
}
