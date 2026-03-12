# 🛒 Pood_andmebaasiga

Windows Forms (.NET Framework 4.7.2) project — shop management system with a LocalDB database.

---

## ❌ Clone error — SSH dialog appears, then "Git failed with a fatal error"

**Symptoms (exactly what you see):**
1. You paste the **HTTPS** URL into Visual Studio's Clone dialog
2. An SSH host-key dialog appears asking you to confirm GitHub's fingerprint
3. You click **OK** — and immediately get:  
   > *Git failed with a fatal error. Could not read from remote repository.  
   > Please make sure you have the correct access rights and the repository exists.*

**Root cause — git URL rewrite (`insteadOf`):**  
Your global git config contains a rule that silently converts every `https://github.com/` URL to `git@github.com:` (SSH) before git even starts the clone. So even though you pasted an HTTPS URL, git is actually connecting over SSH. Because no SSH key is configured for GitHub on this machine, authentication fails and you get the fatal error.

### Fix 1 — Remove the URL rewrite from git config (recommended)

Open **Developer PowerShell** or **Git Bash** and run:

```powershell
git config --global --unset url."git@github.com:".insteadOf
```

Then verify it is gone:

```powershell
git config --global --list | findstr insteadOf
```

The command should return nothing. Now clone again with the HTTPS URL:

```
https://github.com/Nikitagontsrovtkvgee/Tooted_Pood_andmebaasiga.git
```

No SSH dialog will appear and the clone will succeed.

### Fix 2 — Turn off "Prefer SSH" in Visual Studio

Visual Studio has a built-in setting that rewrites HTTPS URLs to SSH:

1. Go to **Tools → Options → Source Control → Git Global Settings**
2. Find **"Prefer SSH to HTTPS"** — set it to **False**
3. Click **OK**, then try cloning again

### Fix 3 — Use SSH properly (if you want to keep SSH)

If you intentionally use SSH and have an SSH key, the host-key dialog is safe — just click **OK**. The fingerprint GitHub shows (`SHA256:+DiY3wvV6TuJJhbpZisF/zLDA0zPMSvHdkr4UvCOqU`) is GitHub's official ED25519 key, so it is legitimate.

The fatal error in this case means your SSH key is **not added to your GitHub account**. Fix it by:

1. Generate a key if you don't have one:  
   ```powershell
   ssh-keygen -t ed25519 -C "your@email.com"
   ```
2. Copy the public key:  
   ```powershell
   cat ~/.ssh/id_ed25519.pub
   ```
3. Go to **github.com → Settings → SSH and GPG keys → New SSH key** and paste it
4. Test: `ssh -T git@github.com` — you should see *"Hi username! You've successfully authenticated"*

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
 ├─ Tooded.mdf            ← LocalDB database (created locally, not in git)
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
