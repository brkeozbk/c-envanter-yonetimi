-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 14 Ara 2020, 17:29:24
-- Sunucu sürümü: 10.4.11-MariaDB
-- PHP Sürümü: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `sirket`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `cilaci_table`
--

CREATE TABLE `cilaci_table` (
  `cilaciID` int(11) NOT NULL,
  `cilaci_adi` varchar(45) NOT NULL,
  `cilaci_siparis` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `iskeletci_table`
--

CREATE TABLE `iskeletci_table` (
  `iskeletciID` int(11) NOT NULL,
  `iskeletci_adi` varchar(45) NOT NULL,
  `iskeletci_siparis` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kdv_table`
--

CREATE TABLE `kdv_table` (
  `kdvID` int(11) NOT NULL,
  `kdv` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kumas_table`
--

CREATE TABLE `kumas_table` (
  `kumasID` int(11) NOT NULL,
  `kumas_adi` varchar(45) NOT NULL,
  `kumas_metresi` int(11) NOT NULL,
  `kumas_siparis` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteri_table`
--

CREATE TABLE `musteri_table` (
  `musteriID` int(11) NOT NULL,
  `musteriAdi` varchar(45) NOT NULL,
  `musteriSoyadi` varchar(45) NOT NULL,
  `musteriTel` varchar(45) NOT NULL,
  `musteriAdres` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `siparis_table`
--

CREATE TABLE `siparis_table` (
  `siparisID` int(11) NOT NULL,
  `musteriID` int(11) NOT NULL,
  `aldigi_adet` int(11) NOT NULL,
  `satis_fiyati` float NOT NULL,
  `nakliye_ucreti` float DEFAULT NULL,
  `alinan_odeme` float DEFAULT NULL,
  `kalan_odeme` float DEFAULT NULL,
  `teslimat_tarihi` datetime DEFAULT NULL,
  `kumasID` int(11) NOT NULL,
  `urunID` int(11) NOT NULL,
  `cilaciID` int(11) NOT NULL,
  `iskeletciID` int(11) NOT NULL,
  `uyeID` int(11) NOT NULL,
  `kdvID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `urun_table`
--

CREATE TABLE `urun_table` (
  `urunID` int(11) NOT NULL,
  `stokkodu` varchar(45) NOT NULL,
  `urunadi` varchar(45) NOT NULL,
  `satisfiyati` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `uye_table`
--

CREATE TABLE `uye_table` (
  `uyeID` int(11) NOT NULL,
  `u_adi` varchar(45) NOT NULL,
  `u_soyadi` varchar(45) NOT NULL,
  `k_adi` varchar(100) NOT NULL,
  `sifre` varchar(100) NOT NULL,
  `rol` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `cilaci_table`
--
ALTER TABLE `cilaci_table`
  ADD PRIMARY KEY (`cilaciID`);

--
-- Tablo için indeksler `iskeletci_table`
--
ALTER TABLE `iskeletci_table`
  ADD PRIMARY KEY (`iskeletciID`);

--
-- Tablo için indeksler `kdv_table`
--
ALTER TABLE `kdv_table`
  ADD PRIMARY KEY (`kdvID`);

--
-- Tablo için indeksler `kumas_table`
--
ALTER TABLE `kumas_table`
  ADD PRIMARY KEY (`kumasID`);

--
-- Tablo için indeksler `musteri_table`
--
ALTER TABLE `musteri_table`
  ADD PRIMARY KEY (`musteriID`);

--
-- Tablo için indeksler `siparis_table`
--
ALTER TABLE `siparis_table`
  ADD PRIMARY KEY (`siparisID`),
  ADD KEY `uyeID` (`uyeID`),
  ADD KEY `urunID` (`urunID`),
  ADD KEY `musteriID` (`musteriID`),
  ADD KEY `cilaciID` (`cilaciID`),
  ADD KEY `iskeletciID` (`iskeletciID`),
  ADD KEY `kdvID` (`kdvID`),
  ADD KEY `kumasID` (`kumasID`);

--
-- Tablo için indeksler `urun_table`
--
ALTER TABLE `urun_table`
  ADD PRIMARY KEY (`urunID`);

--
-- Tablo için indeksler `uye_table`
--
ALTER TABLE `uye_table`
  ADD PRIMARY KEY (`uyeID`);

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `siparis_table`
--
ALTER TABLE `siparis_table`
  ADD CONSTRAINT `siparis_table_ibfk_1` FOREIGN KEY (`uyeID`) REFERENCES `uye_table` (`uyeID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `siparis_table_ibfk_2` FOREIGN KEY (`urunID`) REFERENCES `urun_table` (`urunID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `siparis_table_ibfk_3` FOREIGN KEY (`musteriID`) REFERENCES `musteri_table` (`musteriID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `siparis_table_ibfk_4` FOREIGN KEY (`cilaciID`) REFERENCES `cilaci_table` (`cilaciID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `siparis_table_ibfk_5` FOREIGN KEY (`iskeletciID`) REFERENCES `iskeletci_table` (`iskeletciID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `siparis_table_ibfk_6` FOREIGN KEY (`kdvID`) REFERENCES `kdv_table` (`kdvID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `siparis_table_ibfk_7` FOREIGN KEY (`kumasID`) REFERENCES `kumas_table` (`kumasID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
