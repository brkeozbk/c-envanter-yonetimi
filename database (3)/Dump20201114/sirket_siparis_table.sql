-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: sirket
-- ------------------------------------------------------
-- Server version	5.6.49-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `siparis_table`
--

DROP TABLE IF EXISTS `siparis_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
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
  `kdvID` int(11) NOT NULL,
  PRIMARY KEY (`siparisID`),
  KEY `uyeID` (`uyeID`),
  KEY `urunID` (`urunID`),
  KEY `musteriID` (`musteriID`),
  KEY `cilaciID` (`cilaciID`),
  KEY `iskeletciID` (`iskeletciID`),
  KEY `kdvID` (`kdvID`),
  KEY `kumasID` (`kumasID`),
  CONSTRAINT `siparis_table_ibfk_1` FOREIGN KEY (`uyeID`) REFERENCES `uye_table` (`uyeID`),
  CONSTRAINT `siparis_table_ibfk_2` FOREIGN KEY (`urunID`) REFERENCES `urun_table` (`urunID`),
  CONSTRAINT `siparis_table_ibfk_3` FOREIGN KEY (`musteriID`) REFERENCES `musteri_table` (`musteriID`),
  CONSTRAINT `siparis_table_ibfk_4` FOREIGN KEY (`cilaciID`) REFERENCES `cilaci_table` (`cilaciID`),
  CONSTRAINT `siparis_table_ibfk_5` FOREIGN KEY (`iskeletciID`) REFERENCES `iskeletci_table` (`iskeletciID`),
  CONSTRAINT `siparis_table_ibfk_6` FOREIGN KEY (`kdvID`) REFERENCES `kdv_table` (`kdvID`),
  CONSTRAINT `siparis_table_ibfk_7` FOREIGN KEY (`kumasID`) REFERENCES `kumas_table` (`kumasID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `siparis_table`
--

LOCK TABLES `siparis_table` WRITE;
/*!40000 ALTER TABLE `siparis_table` DISABLE KEYS */;
/*!40000 ALTER TABLE `siparis_table` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-11-14 15:15:09
