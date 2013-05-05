-- phpMyAdmin SQL Dump
-- version 3.4.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 05, 2013 at 03:02 PM
-- Server version: 5.5.16
-- PHP Version: 5.3.8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbtrunojoyo`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE IF NOT EXISTS `barang` (
  `barangid` varchar(7) NOT NULL,
  `barangnama` varchar(25) DEFAULT NULL,
  `harga` double DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `satuan` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`barangid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`barangid`, `barangnama`, `harga`, `jumlah`, `satuan`) VALUES
('KRN01', 'Kran Kecil', 2500, 8, 'Pcs'),
('KRN02', 'Kran Besar', 3000, 37, 'Pcs'),
('LEM01', 'Lem Lilin', 15000, 3, 'Pack'),
('MED01', 'Mumi KW1', 700000, 1, 'Unit'),
('MED02', 'Mumi KW2', 650000, 5, 'Unit'),
('MED03', 'Mumi Balut SS', 950000, 1, 'Unit'),
('MED04', 'Mumi Lon Katjun', 1500000, 3, 'Unit'),
('OZO01', 'RS O25', 625000, 1, 'Unit'),
('PCC01', 'PC-C 19 Liter', 24700, 102, 'Pcs'),
('PCC02', 'PC-C Kran', 27200, 107, 'PCS'),
('PG001', 'Pet Golden 19 Liter', 26800, 68, 'Pcs'),
('PGK01', 'Pet Golden Kran 5 Liter', 15000, 103, 'Pcs'),
('PLJ01', 'Pet LJ 19', 20500, 145, 'Pcs'),
('PLJ02', 'Pet LJ 19 Liter Kran', 23000, 48, 'Pcs'),
('SBR01', 'Segel Biru Polos', 33000, 25, 'Set'),
('SPN10', 'Filter Spoon Nano 10', 6500, 66, 'Pcs'),
('SPN20', 'Filter Spoon Nano 20', 18500, 50, 'Pcs'),
('SSL02', 'Segel Silver Polos', 34000, 5, 'Set'),
('TAN01', 'Tirta', 2550000, 1, 'Unit'),
('TAN02', 'Teamon', 3550000, 1, 'Unit');

-- --------------------------------------------------------

--
-- Table structure for table `barangmasuk`
--

CREATE TABLE IF NOT EXISTS `barangmasuk` (
  `masukid` bigint(20) NOT NULL AUTO_INCREMENT,
  `masuknofaktur` char(14) DEFAULT NULL,
  `masuktgl` date DEFAULT NULL,
  `masukpemasokid` varchar(11) DEFAULT NULL,
  `masukbarangid` varchar(7) DEFAULT NULL,
  `masukqty` int(11) DEFAULT NULL,
  `masukuserinput` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`masukid`),
  KEY `masukpemasokid` (`masukpemasokid`),
  KEY `masukbarangid` (`masukbarangid`),
  KEY `masukuserinput` (`masukuserinput`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=66 ;

--
-- Dumping data for table `barangmasuk`
--

INSERT INTO `barangmasuk` (`masukid`, `masuknofaktur`, `masuktgl`, `masukpemasokid`, `masukbarangid`, `masukqty`, `masukuserinput`) VALUES
(61, 'DL-0003', '2013-01-10', 'PA-002', 'KRN01', 2, 'ricky'),
(62, 'DL-0003', '2013-01-10', 'PA-002', 'LEM01', 3, 'ricky'),
(63, 'DL-0003', '2013-01-10', 'PA-002', 'MED01', 5, 'ricky'),
(64, 'DL-0004', '2013-01-15', 'PA-002', 'KRN01', 5, 'ricky'),
(65, 'DL-0004', '2013-01-15', 'PA-002', 'KRN02', 10, 'ricky');

--
-- Triggers `barangmasuk`
--
DROP TRIGGER IF EXISTS `tri_stok_barang_masuk`;
DELIMITER //
CREATE TRIGGER `tri_stok_barang_masuk` AFTER INSERT ON `barangmasuk`
 FOR EACH ROW BEGIN
		update barang set jumlah = jumlah + new.masukqty where barangid = new.masukbarangid;
    END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `kanvas`
--

CREATE TABLE IF NOT EXISTS `kanvas` (
  `kanvasid` int(20) NOT NULL AUTO_INCREMENT,
  `kanvasnofaktur` char(14) DEFAULT NULL,
  `kanvastgl` date DEFAULT NULL,
  `kanvasuserid` varchar(11) DEFAULT NULL,
  `kanvasbarangid` varchar(11) DEFAULT NULL,
  `kanvasharga` double DEFAULT NULL,
  `kanvasqty` int(11) DEFAULT NULL,
  `kanvasuserinput` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`kanvasid`),
  KEY `kanvasuserid` (`kanvasuserid`),
  KEY `kanvasbarangid` (`kanvasbarangid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=110 ;

--
-- Dumping data for table `kanvas`
--

INSERT INTO `kanvas` (`kanvasid`, `kanvasnofaktur`, `kanvastgl`, `kanvasuserid`, `kanvasbarangid`, `kanvasharga`, `kanvasqty`, `kanvasuserinput`) VALUES
(52, 'K-000110012013', '2013-01-10', 'ferry', 'KRN01', 2500, 2, 'ricky'),
(53, 'K-000110012013', '2013-01-10', 'ferry', 'KRN02', 3000, 3, 'ricky'),
(54, 'K-000110012013', '2013-01-10', 'ferry', 'MED02', 650000, 3, 'ricky'),
(55, 'K-000211012013', '2013-01-11', 'ferry', 'KRN01', 2500, 20, 'ricky'),
(56, 'K-000211012013', '2013-01-11', 'ferry', 'MED04', 1500000, 2, 'ricky'),
(57, 'K-000211012013', '2013-01-11', 'ferry', 'PCC01', 24700, 40, 'ricky'),
(58, 'K-000211012013', '2013-01-11', 'ferry', 'PG001', 26800, 2, 'ricky'),
(60, 'K-000311012013', '2013-01-11', 'ferry', 'MED01', 700000, 2, 'ricky'),
(62, 'K-000411012013', '2013-01-11', 'ferry', 'PLJ02', 23000, 5, 'ricky'),
(64, 'K-000511012013', '2013-01-11', 'ferry', 'PGK01', 15000, 10, 'ricky'),
(65, 'K-000611012013', '2013-01-11', 'ferry', 'SPN20', 18500, 1, 'ricky'),
(66, 'K-000711012013', '2013-01-11', 'ferry', 'PG001', 26800, 3, 'ricky'),
(67, 'K-000812012013', '2013-01-12', 'ferry', 'LEM01', 15000, 1, 'ricky'),
(69, 'K-000912012013', '2013-01-12', 'ferry', 'LEM01', 15000, 1, 'ricky'),
(71, 'K-001012012013', '2013-01-12', 'ferry', 'PLJ01', 20500, 20, 'ricky'),
(73, 'K-001112012013', '2013-01-12', 'ferry', 'SPN10', 6500, 10, 'ricky'),
(75, 'K-001212012013', '2013-01-12', 'ferry', 'PCC02', 27200, 10, 'ricky'),
(77, 'K-001312012013', '2013-01-12', 'ferry', 'PCC01', 24700, 1, 'ricky'),
(79, 'K-001412012013', '2013-01-12', 'ferry', 'PCC02', 27200, 30, 'ricky'),
(80, 'K-001412012013', '2013-01-12', 'ferry', 'OZO01', 625000, 1, 'ricky'),
(82, 'K-001512012013', '2013-01-12', 'ferry', 'PG001', 26800, 20, 'ricky'),
(84, 'K-001612012013', '2013-01-12', 'ferry', 'KRN01', 2500, 10, 'ricky'),
(86, 'K-001712012013', '2013-01-12', 'ferry', 'PCC02', 27200, 20, 'ricky'),
(87, 'K-001712012013', '2013-01-12', 'ferry', 'PG001', 26800, 10, 'ricky'),
(88, 'K-001712012013', '2013-01-12', 'ferry', 'LEM01', 15000, 1, 'ricky'),
(89, 'K-001712012013', '2013-01-12', 'ferry', 'PG001', 26800, 2, 'ricky'),
(90, 'K-001813012013', '2013-01-13', 'ferry', 'MED01', 700000, 2, 'ricky'),
(91, 'K-001813012013', '2013-01-13', 'ferry', 'PG001', 26800, 3, 'ricky'),
(92, 'K-001920012013', '2013-01-20', 'nanda ', 'KRN01', 2500, 6, 'ricky'),
(93, 'K-001920012013', '2013-01-20', 'nanda ', 'MED01', 700000, 2, 'ricky'),
(94, 'K-002023012013', '2013-01-23', 'dian', 'KRN01', 2500, 2, 'ricky'),
(95, 'K-002023012013', '2013-01-23', 'dian', 'MED01', 700000, 2, 'ricky'),
(96, 'K-002023012013', '2013-01-23', 'dian', 'OZO01', 625000, 1, 'ricky'),
(97, 'K-002023012013', '2013-01-23', 'dian', 'PCC01', 24700, 20, 'ricky'),
(98, 'K-002023012013', '2013-01-23', 'dian', 'PGK01', 15000, 10, 'ricky'),
(99, 'K-002124012013', '2013-01-24', 'ferry', 'pcc01', 24700, 12, 'ricky'),
(100, 'K-002212032013', '2013-03-12', 'ferry', 'krn01', 2500, 2, 'yulia'),
(101, 'K-002326042013', '2013-04-26', 'ferry', 'KRN01', 2500, 4, 'ricky'),
(102, 'K-002326042013', '2013-04-26', 'ferry', 'PCC02', 27200, 20, 'ricky'),
(103, 'K-002326042013', '2013-04-26', 'ferry', 'MED04', 1500000, 3, 'ricky'),
(104, 'K-002426042013', '2013-04-26', 'ferry', 'krn01', 2500, 10, 'ricky'),
(105, 'K-002426042013', '2013-04-26', 'ferry', 'med01', 700000, 4, 'ricky'),
(107, 'K-002526042013', '2013-04-26', 'Imam', 'krn01', 2500, 10, 'ricky'),
(108, 'K-002526042013', '2013-04-26', 'Imam', 'krn02', 3000, 20, 'ricky');

--
-- Triggers `kanvas`
--
DROP TRIGGER IF EXISTS `tri_barang_keluar`;
DELIMITER //
CREATE TRIGGER `tri_barang_keluar` AFTER INSERT ON `kanvas`
 FOR EACH ROW BEGIN
UPDATE barang SET jumlah = jumlah - new.kanvasqty WHERE barangid = new.kanvasbarangid;
    END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `level`
--

CREATE TABLE IF NOT EXISTS `level` (
  `levelid` int(11) NOT NULL AUTO_INCREMENT,
  `levelakses` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`levelid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `level`
--

INSERT INTO `level` (`levelid`, `levelakses`) VALUES
(1, 'Admin'),
(2, 'Pimpinan'),
(3, 'Sales'),
(4, 'Gudang');

-- --------------------------------------------------------

--
-- Table structure for table `pelanggan`
--

CREATE TABLE IF NOT EXISTS `pelanggan` (
  `pelangganid` varchar(11) NOT NULL,
  `pelanggannama` varchar(25) DEFAULT NULL,
  `pelanggannohp` varchar(15) DEFAULT NULL,
  `pelangganalamat` varchar(35) DEFAULT NULL,
  `pelanggankota` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`pelangganid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pelanggan`
--

INSERT INTO `pelanggan` (`pelangganid`, `pelanggannama`, `pelanggannohp`, `pelangganalamat`, `pelanggankota`) VALUES
('PL-001', 'Jhony', '08126762345', 'Jln. Khatib Sulaiman No. 4 ', 'Padang'),
('PL-002', 'Jhono', '08136318823', 'Jln. Raya Siteba No. 2', 'Padang'),
('PL-003', 'Jhone', '081266311432', 'Jln. Gunung Pangilun No. 4 C', 'Padang'),
('PL-004', 'Rini Asmara', '0811662142', 'Jln. Khatib Sulaiman', 'Padang');

-- --------------------------------------------------------

--
-- Table structure for table `pemasok`
--

CREATE TABLE IF NOT EXISTS `pemasok` (
  `pemasokid` varchar(11) NOT NULL,
  `pemasoknama` varchar(25) DEFAULT NULL,
  `pemasokalamat` varchar(30) DEFAULT NULL,
  `pemasokkota` varchar(25) DEFAULT NULL,
  `pemasoktelepon` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`pemasokid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pemasok`
--

INSERT INTO `pemasok` (`pemasokid`, `pemasoknama`, `pemasokalamat`, `pemasokkota`, `pemasoktelepon`) VALUES
('PA-001', 'PT Crystal Citra Mandiri ', 'Jln.  Aksara No. 12  A', 'Jakarta', '021-2018045'),
('PA-002', 'Dragon Live', 'Jln. Timur Agung Blok C No. 54', 'Jakarta', '021-228733'),
('PA-003', 'PT. Fighter Century', 'Jln. Kemerdekaan No. 14', 'Pekanbaru', '061-89929'),
('PL-004', 'PT. TDI', 'Jln. Medan No. 18', 'Padang', '0751443514');

-- --------------------------------------------------------

--
-- Table structure for table `penjualankanvas`
--

CREATE TABLE IF NOT EXISTS `penjualankanvas` (
  `pjkvid` int(20) NOT NULL AUTO_INCREMENT,
  `pjkvnofak` char(14) DEFAULT NULL,
  `pjkvtgl` date DEFAULT NULL,
  `notakanvasid` int(20) DEFAULT NULL,
  `kanvasnofaktur` char(14) DEFAULT NULL,
  `barangid` varchar(7) DEFAULT NULL,
  `jumlahterjual` int(11) DEFAULT NULL,
  `sisabrgkanvas` int(11) DEFAULT NULL,
  `pjkanvasuserinput` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`pjkvid`),
  KEY `barangid` (`barangid`),
  KEY `notakanvasid` (`notakanvasid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=80 ;

--
-- Dumping data for table `penjualankanvas`
--

INSERT INTO `penjualankanvas` (`pjkvid`, `pjkvnofak`, `pjkvtgl`, `notakanvasid`, `kanvasnofaktur`, `barangid`, `jumlahterjual`, `sisabrgkanvas`, `pjkanvasuserinput`) VALUES
(16, 'V-000213012013', '2013-01-13', 55, 'K-000211012013', 'KRN01', 10, 10, 'ricky'),
(17, 'V-000213012013', '2013-01-13', 55, 'K-000211012013', 'MED04', 0, 2, 'ricky'),
(18, 'V-000213012013', '2013-01-13', 55, 'K-000211012013', 'PCC01', 5, 35, 'ricky'),
(19, 'V-000213012013', '2013-01-13', 55, 'K-000211012013', 'PG001', 1, 1, 'ricky'),
(24, 'V-000313012013', '2013-01-13', 60, 'K-000311012013', 'MED01', 0, 2, 'ricky'),
(33, 'V-000413012013', '2013-01-13', 62, 'K-000411012013', 'PLJ02', 2, 3, 'ricky'),
(35, 'V-000513012013', '2013-01-13', 64, 'K-000511012013', 'PGK01', 5, 5, 'ricky'),
(37, 'V-000613012013', '2013-01-13', 65, 'K-000611012013', 'SPN20', 0, 1, 'ricky'),
(39, 'V-000713012013', '2013-01-13', 66, 'K-000711012013', 'PG001', 2, 1, 'ricky'),
(41, 'V-000813012013', '2013-01-13', 86, 'K-001712012013', 'LEM01', 0, 1, 'ricky'),
(43, 'V-000913012013', '2013-01-13', 67, 'K-000812012013', 'LEM01', 0, 1, 'ricky'),
(45, 'V-001013012013', '2013-01-13', 69, 'K-000912012013', 'LEM01', 0, 1, 'ricky'),
(46, 'V-001113012013', '2013-01-13', 71, 'K-001012012013', 'PLJ01', 5, 15, 'ricky'),
(48, 'V-001213012013', '2013-01-13', 73, 'K-001112012013', 'SPN10', 4, 6, 'ricky'),
(50, 'V-001313012013', '2013-01-13', 77, 'K-001312012013', 'PCC01', 1, 0, 'ricky'),
(52, 'V-001413012013', '2013-01-13', 79, 'K-001412012013', 'OZO01', 0, 1, 'ricky'),
(53, 'V-001413012013', '2013-01-13', 79, 'K-001412012013', 'PCC02', 2, 28, 'ricky'),
(55, 'V-001513012013', '2013-01-13', 82, 'K-001512012013', 'PG001', 13, 7, 'ricky'),
(59, 'V-001614012013', '2013-01-14', 90, 'K-001813012013', 'MED01', 1, 1, 'ricky'),
(60, 'V-001614012013', '2013-01-14', 90, 'K-001813012013', 'PG001', 2, 1, 'ricky'),
(61, 'V-001715012013', '2013-01-15', 52, 'K-000110012013', 'KRN01', 2, 0, 'ricky'),
(62, 'V-001715012013', '2013-01-15', 52, 'K-000110012013', 'KRN02', 1, 2, 'ricky'),
(63, 'V-001715012013', '2013-01-15', 52, 'K-000110012013', 'MED02', 0, 3, 'ricky'),
(67, 'V-001920012013', '2013-01-20', 92, 'K-001920012013', 'KRN01', 2, 4, 'ricky'),
(68, 'V-001920012013', '2013-01-20', 92, 'K-001920012013', 'MED01', 1, 1, 'ricky'),
(69, 'V-002023012013', '2013-01-23', 94, 'K-002023012013', 'KRN01', 1, 1, 'ricky'),
(70, 'V-002023012013', '2013-01-23', 94, 'K-002023012013', 'MED01', 1, 1, 'ricky'),
(71, 'V-002023012013', '2013-01-23', 94, 'K-002023012013', 'OZO01', 1, 0, 'ricky'),
(72, 'V-002023012013', '2013-01-23', 94, 'K-002023012013', 'PCC01', 2, 18, 'ricky'),
(73, 'V-002023012013', '2013-01-23', 94, 'K-002023012013', 'PGK01', 2, 8, 'ricky'),
(74, 'V-002124012013', '2013-01-24', 99, 'K-002124012013', 'pcc01', 10, 2, 'ricky'),
(75, 'V-002226042013', '2013-04-26', 101, 'K-002326042013', 'KRN01', 2, 2, 'ricky'),
(76, 'V-002226042013', '2013-04-26', 101, 'K-002326042013', 'MED04', 1, 2, 'ricky'),
(77, 'V-002226042013', '2013-04-26', 101, 'K-002326042013', 'PCC02', 1, 19, 'ricky'),
(78, 'V-002326042013', '2013-04-26', 107, 'K-002526042013', 'krn01', 5, 5, 'ricky'),
(79, 'V-002326042013', '2013-04-26', 107, 'K-002526042013', 'krn02', 10, 10, 'ricky');

--
-- Triggers `penjualankanvas`
--
DROP TRIGGER IF EXISTS `tri_sisa_kanvas`;
DELIMITER //
CREATE TRIGGER `tri_sisa_kanvas` AFTER INSERT ON `penjualankanvas`
 FOR EACH ROW BEGIN
	UPDATE barang SET jumlah = jumlah + new.sisabrgkanvas WHERE barangid = new.barangid;
    END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `username` varchar(30) NOT NULL,
  `userfullname` varchar(50) DEFAULT NULL,
  `jenkel` varchar(20) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `telepon` varchar(15) DEFAULT NULL,
  `userpass` varchar(32) DEFAULT NULL,
  `userlevelid` int(11) DEFAULT NULL,
  `useraktif` char(1) DEFAULT NULL,
  `validasi` int(11) DEFAULT NULL,
  PRIMARY KEY (`username`),
  KEY `userlevelid` (`userlevelid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `userfullname`, `jenkel`, `alamat`, `telepon`, `userpass`, `userlevelid`, `useraktif`, `validasi`) VALUES
('dian', 'Dian Hanita', 'Wanita', 'Jln. Banuaran No. 40', '0812116578', '285ba4b00193f73f24eab9915c199502', 3, 'Y', 1),
('Doni', 'Doni Aldi', 'Pria', 'Jln. Terandam No. 3', '08136322221', '3de4053fbbeb95047d705a2a20f76246', 2, 'Y', 1),
('ferry', 'Ferry Daniel', 'Pria', 'Perumnas Belimbing Blok A No. 9', '081363744414', 'aa47f8215c6f30a0dcdb2a36a9f4168e', 3, 'Y', 1),
('Imam', 'Imam Gunawan M Kom', 'Pria', 'Padang', '0813631232', 'dc96b97c4ffbead46ca25ef5d4b77cbe', 3, 'Y', 1),
('isnardi', 'Isnardi M.Kom', 'Pria', 'Siteba', '081234', 'e10adc3949ba59abbe56e057f20f883e', 1, 'Y', 1),
('nanda ', 'Nanda Wijaya', 'Pria', 'Jln. Azizi No. 5 B  Andalas', '081363454515', 'd5ae0f43f56adb44d5a48f9605794c27', 3, 'Y', 1),
('Rani', 'Lusia', 'Wanita', 'Banuaran', '075138404', 'e03e8fa44f5a0128538388931abc9163', 4, 'Y', 1),
('ricky', 'Ricky Kurniawan', 'Pria', 'Jln. Blk. Pasar Simpang Haru No. 4', '081363158070', '16ca55b4f29157780eabc6244f49d442', 1, 'Y', 1);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `barangmasuk`
--
ALTER TABLE `barangmasuk`
  ADD CONSTRAINT `barangmasuk_ibfk_1` FOREIGN KEY (`masukpemasokid`) REFERENCES `pemasok` (`pemasokid`) ON UPDATE CASCADE,
  ADD CONSTRAINT `barangmasuk_ibfk_2` FOREIGN KEY (`masukbarangid`) REFERENCES `barang` (`barangid`) ON UPDATE CASCADE,
  ADD CONSTRAINT `barangmasuk_ibfk_3` FOREIGN KEY (`masukuserinput`) REFERENCES `user` (`username`) ON UPDATE CASCADE;

--
-- Constraints for table `kanvas`
--
ALTER TABLE `kanvas`
  ADD CONSTRAINT `kanvas_ibfk_1` FOREIGN KEY (`kanvasuserid`) REFERENCES `user` (`username`) ON UPDATE CASCADE,
  ADD CONSTRAINT `kanvas_ibfk_2` FOREIGN KEY (`kanvasbarangid`) REFERENCES `barang` (`barangid`) ON UPDATE CASCADE;

--
-- Constraints for table `penjualankanvas`
--
ALTER TABLE `penjualankanvas`
  ADD CONSTRAINT `penjualankanvas_ibfk_1` FOREIGN KEY (`barangid`) REFERENCES `barang` (`barangid`) ON UPDATE CASCADE,
  ADD CONSTRAINT `penjualankanvas_ibfk_2` FOREIGN KEY (`notakanvasid`) REFERENCES `kanvas` (`kanvasid`) ON UPDATE CASCADE;

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_ibfk_1` FOREIGN KEY (`userlevelid`) REFERENCES `level` (`levelid`) ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
