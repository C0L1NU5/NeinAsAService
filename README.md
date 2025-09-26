# ❌ NeinAsAService

Schon mal eine elegante Art gebraucht, einfach **„NEIN“** zu sagen?  
Diese kleine API gibt ein lautes **NEEEEEEEEEEIN** zurück – direkt, ehrlich, humorvoll.  

Erstellt während eines **Schülerpraktikums** mit C#.

## 🙌 Credits

Dieses Projekt **NeinAsAService** wurde inspiriert von  
[No-as-a-Service](https://github.com/hotheadhacker/no-as-a-service).  

---

## 🚀 API Nutzung

**Basis-URL:**  
```
https://localhost:5001/nein
```

**Methode:** `GET`  
**Rate Limit:** no idea

---

### 🔄 Beispiel Anfrage
```http
GET /nein
```

### ✅ Beispiel Antwort
```json
{
  "id": "dff45b55-6478-4207-800d-c0fb565ce3d8",
  "text": "NEEEEEEEEEEIN"
}
```

Nutze es in **Apps, Bots, Websites, Projekten** oder einfach, wenn nur ein fettes **NEIN** passt.  

---

## 🛠️ Selbst Hosten

Willst du es selbst laufen lassen?  
Ganz leicht – mit .NET:

1. Repository klonen  
   ```bash
   git clone https://github.com/C0L1NU5/NeinAsAService.git
   cd NeinAsAService
   ```

2. Abhängigkeiten wiederherstellen  
   ```bash
   dotnet restore
   ```

3. Server starten  
   ```bash
   dotnet run
   ```

➡️ Die API läuft dann unter:  
```
https://localhost:7281 (oder was auch immer in der Konsole steht)
```

---

## 📁 Projektstruktur

```plaintext
NeinAsAService
├── VerbundeneDienste
├── Abhängigkeiten
├── Eigenschaften
│   └── launchSettings.json
├── Steuerungen
│   └── NeinController.cs
├── Migrationen
│   ├── 20250924122016_init.cs
│   ├── 20250924122434_ChangeIntToGuid.cs
│   └── AppDbContextModelSnapshot.cs
├── Modelle
│   └── Antwort.cs
├── AppDbContext.cs
├── appsettings.json
├── NeinAsAService.http
├── Keine.Db
└── Programm.cs
```

---

## ⚓ Hinweis

Dieses Projekt entstand **während eines Schülerpraktikums!!!**
