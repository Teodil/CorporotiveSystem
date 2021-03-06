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
-- Table structure for table `сoming`
--

DROP TABLE IF EXISTS `сoming`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `сoming` (
  `id` int NOT NULL AUTO_INCREMENT,
  `СomingDate` date NOT NULL,
  `Supplier_id` int NOT NULL,
  `Warehouse_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Сoming_Supplier_idx` (`Supplier_id`),
  KEY `fk_Сoming_Warehouse1_idx` (`Warehouse_id`),
  CONSTRAINT `fk_Сoming_Supplier` FOREIGN KEY (`Supplier_id`) REFERENCES `supplier` (`id`),
  CONSTRAINT `fk_Сoming_Warehouse1` FOREIGN KEY (`Warehouse_id`) REFERENCES `warehouse` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `сoming`
--

LOCK TABLES `сoming` WRITE;
/*!40000 ALTER TABLE `сoming` DISABLE KEYS */;
INSERT INTO `сoming` VALUES (28,'2020-02-20',1,1),(29,'2020-02-28',2,1),(30,'2020-03-01',3,1),(31,'2020-02-20',1,2),(32,'2020-02-28',2,2),(33,'2020-03-01',3,2),(34,'2020-02-20',1,3),(35,'2020-02-28',2,3),(36,'2020-03-01',3,3),(44,'2020-03-04',1,1),(45,'2020-03-16',2,2),(46,'2020-03-17',3,3),(47,'2020-05-20',1,1);
/*!40000 ALTER TABLE `сoming` ENABLE KEYS */;
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
