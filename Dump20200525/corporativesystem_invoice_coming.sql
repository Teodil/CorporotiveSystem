-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: corporativesystem
-- ------------------------------------------------------
-- Server version	8.0.19

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
-- Table structure for table `invoice_coming`
--

DROP TABLE IF EXISTS `invoice_coming`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoice_coming` (
  `Сoming_id` int NOT NULL,
  `Product_id` int NOT NULL,
  `Amount` double NOT NULL,
  `Price` double NOT NULL,
  KEY `fk_Сoming_has_Product_Product1_idx` (`Product_id`),
  KEY `fk_Сoming_has_Product_Сoming1_idx` (`Сoming_id`),
  CONSTRAINT `fk_Сoming_has_Product_Product1` FOREIGN KEY (`Product_id`) REFERENCES `product` (`id`),
  CONSTRAINT `fk_Сoming_has_Product_Сoming1` FOREIGN KEY (`Сoming_id`) REFERENCES `сoming` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoice_coming`
--

LOCK TABLES `invoice_coming` WRITE;
/*!40000 ALTER TABLE `invoice_coming` DISABLE KEYS */;
INSERT INTO `invoice_coming` VALUES (28,1,300,10),(29,2,500,15),(30,3,600,60),(31,1,300,10),(32,2,500,15),(33,3,600,60),(34,1,300,10),(35,2,500,15),(36,3,600,60),(44,1,300,5),(45,1,500,12),(46,1,600,34),(47,3,150,34);
/*!40000 ALTER TABLE `invoice_coming` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-25  0:55:19
