# Pood_andmebaasiga — SQL-skriptid

## Andmebaas: Tooded.mdf (LocalDB)

### Ühendusstring
```
Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Tooded.mdf;Integrated Security=True
```

---

## Tabelid

### 1. Kategooria
```sql
CREATE TABLE Kategooria (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Kategooria_nimetus NVARCHAR(100)
);
```

### 2. Tooded
```sql
CREATE TABLE Tooded (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Toodenimetus NVARCHAR(100),
    Kogus INT DEFAULT 0,
    Hind DECIMAL(10,2) DEFAULT 0,
    Pilt NVARCHAR(255),
    Kategooriad_ID INT,
    FOREIGN KEY (Kategooriad_ID) REFERENCES Kategooria(Id)
);
```

### 3. Kasutajad
```sql
CREATE TABLE Kasutajad (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Kasutajanimi NVARCHAR(100),
    Parool NVARCHAR(255),
    Roll NVARCHAR(50)
);
```

Rollid: `Admin`, `Omanik`, `Müüja`

### 4. Kliendid
```sql
CREATE TABLE Kliendid (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nimi NVARCHAR(100),
    Kliendikaart NVARCHAR(50),
    Boonus DECIMAL(10,2) DEFAULT 0
);
```

---

## Testandmed

### Kasutajad
```sql
INSERT INTO Kasutajad (Kasutajanimi, Parool, Roll) VALUES ('admin', 'admin123', 'Admin');
INSERT INTO Kasutajad (Kasutajanimi, Parool, Roll) VALUES ('omanik', 'omanik123', 'Omanik');
INSERT INTO Kasutajad (Kasutajanimi, Parool, Roll) VALUES ('müüja', 'muuja123', 'Müüja');
```

### Kategooriad
```sql
INSERT INTO Kategooria (Kategooria_nimetus) VALUES ('Toidutooted');
INSERT INTO Kategooria (Kategooria_nimetus) VALUES ('Joogid');
INSERT INTO Kategooria (Kategooria_nimetus) VALUES ('Maiustused');
```

---

## Märkused

- Arved (PDF-tšekid) salvestatakse kausta `Arved/` käivituskataloogi (bin\Debug\Arved\).
- Pildifailid: salvestada täielik tee (nt `C:\Users\...\Images\toode.jpg`).
- Kogus väheneb automaatselt korvi lisamisel; korvist eemaldamisel tagastatakse.
