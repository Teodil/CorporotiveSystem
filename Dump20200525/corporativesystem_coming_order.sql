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
-- Table structure for table `coming_order`
--

DROP TABLE IF EXISTS `coming_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `coming_order` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Date` date DEFAULT NULL,
  `Warehouse_id` int NOT NULL,
  `Supplier_id` int NOT NULL,
  `Status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Coming_Order_Warehouse1_idx` (`Warehouse_id`),
  KEY `fk_Coming_Order_Supplier1_idx` (`Supplier_id`),
  CONSTRAINT `fk_Coming_Order_Supplier1` FOREIGN KEY (`Supplier_id`) REFERENCES `supplier` (`id`),
  CONSTRAINT `fk_Coming_Order_Warehouse1` FOREIGN KEY (`Warehouse_id`) REFERENCES `warehouse` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `coming_order`
--

LOCK TABLES `coming_order` WRITE;
/*!40000 ALTER TABLE `coming_order` DISABLE KEYS */;
INSERT INTO `coming_order` VALUES (1,'2020-02-25',1,1,'Принят'),(2,'2020-02-25',2,2,'Принят'),(3,'2020-02-25',3,3,'Принят'),(4,'2020-03-02',1,1,'Принят'),(5,'2020-03-02',2,2,'Принят'),(6,'2020-03-02',3,3,'Принят'),(7,'2020-03-03',1,1,'Принят'),(8,'2020-05-25',1,1,'Ожидает прибытия'),(9,'2020-05-25',1,1,'Ожидает прибытия'),(10,'2020-05-25',1,2,'Ожидает прибытия'),(11,'2020-05-25',1,2,'Ожидает прибытия');
/*!40000 ALTER TABLE `coming_order` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-25  0:55:18
