<img src="media/RatLogo.png" height=100 align=right>

# Rat Stash

Rat Stash is a open source library for parsing and using item data from [Escape from Tarkov][escape-from-tarkov].

<br/>

## How to use

The fast way: Finding a item by it's Id
```csharp
Database database = Database.FromFile("items.json");
Item item = database.GetItem("5644bd2b4bdc2d3b4c8b4572");
Console.WriteLine(item.Name);   // > "AK-74N 5.45x39 assault rifle"
```

Finding a item by any other property
```csharp
Database database = Database.FromFile("items.json");
IEnumerable<Item> items = database.GetItems(item => item.ShortName == "MRE");
Item firstFoundItem = items.FirstOrDefault();   // First item matching our query
Console.WriteLine(firstFoundItem.Name);         // > "MRE lunch box"
```

Getting all items in the database to perform custom operations
```csharp
Database database = Database.FromFile("items.json");
IEnumerable<Item> items = database.GetItems();
Console.WriteLine(items.Count());   // > 2245
```

---

Parsing the item cache index
```csharp
Database database = Database.FromFile("items.json");
Dictionary<int, (Item, ItemExtraInfo)> cacheIndex = database.ParseItemCacheHashIndex("index.json");
Console.WriteLine(cacheIndex[14].item.ShortName);
```

<br/>

## Support the project

<br/>

[![Patreon](https://img.shields.io/badge/dynamic/json?color=%23e85b46&label=Patreon&query=data.attributes.patron_count&suffix=%20patrons&url=https%3A%2F%2Fwww.patreon.com%2Fapi%2Fcampaigns%2F4117180&style=for-the-badge&logo=patreon)](https://patreon.com/RatScanner)
[![PayPal](https://img.shields.io/static/v1?&label=PayPal&message=Donate&color=0079C1&style=for-the-badge&logo=paypal)](https://paypal.me/mscheve)

[escape-from-tarkov]: https://www.escapefromtarkov.com/
[discord]: https://discord.com/invite/aHZf7aP
