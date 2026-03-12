# 🛒 Pood_andmebaasiga

Windows Forms (.NET Framework 4.7.2) project — shop management system with a LocalDB database.

---

## ⚠️ Cloning problem — "Git for Windows" SSH dialog

When cloning the repository for the first time, Visual Studio (Git for Windows) may show a dialog like this:

```
The authenticity of host 'github.com (140.82.121.4)' can't be established.
ED25519 key fingerprint is SHA256:+DIY3wvV6TuJJhbpZisF/zLDA0zPMSvHdkr4UvCOqU.
This key is not known by any other names.
```

**✅ Solution: Click "OK".**

This is a standard security prompt that appears when connecting to GitHub via SSH for the first time. Git is asking you to confirm that you trust GitHub's server. GitHub's official ED25519 fingerprint is:

```
SHA256:+DiY3wvV6TuJJhbpZisF/zLDA0zPMSvHdkr4UvCOqU
```

This matches — so it is safe to click **OK**.

### Alternative: Clone via HTTPS (no SSH dialog)

If you want to avoid SSH altogether, clone using the HTTPS URL instead of SSH:

1. In Visual Studio: **Git → Clone Repository...**
2. Paste the HTTPS URL:
   ```
   https://github.com/Nikitagontsrovtkvgee/Tooted_Pood_andmebaasiga.git
   ```
3. Choose a local folder and click **Clone** — no SSH key dialog will appear.

---

## ❌ HTTPS clone error — "Git failed with a fatal error. Could not read from remote repository"

If cloning via HTTPS gives this error even though the repository is **public**, the most common cause is **stale or incorrect GitHub credentials stored in Windows Credential Manager**.

### Step-by-step fix

1. Open **Windows Credential Manager**  
   (Start → search "Credential Manager" → open **Windows Credentials** tab)

2. Find any entries that mention **github.com**, for example:
   - `git:https://github.com`
   - `GitHub — https://github.com`

3. Click each one → **Remove** (or **Edit** and clear the password)

4. Return to Visual Studio and clone again:
   ```
   https://github.com/Nikitagontsrovtkvgee/Tooted_Pood_andmebaasiga.git
   ```
   Visual Studio will now ask you to sign in to GitHub — enter your credentials and the clone will succeed.

### Alternative fix — re-authenticate directly in Visual Studio

1. **File → Account Settings...**
2. Click **Sign out** next to your GitHub account
3. Click **Sign in** and authenticate with your GitHub username/password (or browser OAuth)
4. Try cloning again

### Why does this happen?

When your GitHub password changes or your Personal Access Token expires, Windows keeps the old credentials cached. Even for **public** repositories, Visual Studio sends these cached credentials automatically; GitHub rejects them and Git reports a fatal error instead of silently skipping authentication.

---

## 🛠️ Requirements

- **Visual Studio 2022** (or 2019) with the **.NET desktop development** workload
- **.NET Framework 4.7.2**
- **SQL Server Express LocalDB** (installed automatically with Visual Studio)

---

## 🚀 Getting Started

### 1. Clone the repository

```
https://github.com/Nikitagontsrovtkvgee/Tooted_Pood_andmebaasiga.git
```

Open `Pood_andmebaasiga.slnx` in Visual Studio.

### 2. Restore NuGet packages

Right-click the solution → **Restore NuGet Packages**  
(iTextSharp 5.5.13.5 and BouncyCastle are required)

### 3. Set up the database

> **Note:** The `.mdf` database file is **not stored in git** (it is listed in `.gitignore` because binary database files should not be version-controlled). You must create it once, following these steps:

1. Open **View → Server Explorer** in Visual Studio
2. Right-click **Data Connections** → **Add Connection...**
3. Choose **Microsoft SQL Server Database File** as the data source
4. Click **New...** and save as `Tooded.mdf` inside the `Pood_andmebaasiga\` folder
5. Right-click the new connection → **New Query**
6. Run the SQL scripts from [README_SQL.md](README_SQL.md) to create all tables

### 4. Insert test users

```sql
INSERT INTO Kasutajad (Kasutajanimi, Parool, Roll) VALUES ('admin',   'admin123',   'Admin');
INSERT INTO Kasutajad (Kasutajanimi, Parool, Roll) VALUES ('omanik',  'omanik123',  'Omanik');
INSERT INTO Kasutajad (Kasutajanimi, Parool, Roll) VALUES ('myüja',   'muuja123',   'Müüja');
```

### 5. Build and run

Press **F5** or click **Start**. The login form opens.

---

## 👤 User roles

| Role | Access |
|------|--------|
| `Admin` | Full access: Tooded (products) + Kassa (cash register) |
| `Omanik` | Full access: Tooded + Kassa + Admin Panel |
| `Müüja` | Cash register (Kassa) only |

---

## 📁 Project structure

```
Pood_andmebaasiga/
 ├─ Program.cs            ← entry point → opens Login form
 ├─ Login.cs / .Designer  ← login form with role routing
 ├─ Register.cs           ← new user registration
 ├─ Tooded.cs             ← product management (admin/owner)
 ├─ Kassa.cs              ← shop / cash register (buyer view)
 ├─ AdminPanel.cs         ← user management
 ├─ Kliendid.cs           ← client card management
 ├─ Tooded.mdf            ← LocalDB database
 └─ Images/               ← sample product images
```

---

## 📄 PDF receipts

After a purchase, a PDF receipt is saved automatically to:
```
bin\Debug\Arved\arve_YYYYMMDD_HHmmss.pdf
```
The file opens automatically after creation.

---

## 🗄️ Full SQL scripts

See [README_SQL.md](README_SQL.md) for all `CREATE TABLE` statements and sample data.
