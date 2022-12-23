-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 02, 2022 at 06:28 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_apotek`
--

-- --------------------------------------------------------

--
-- Table structure for table `detail_penjualan`
--

CREATE TABLE `detail_penjualan` (
  `no_penjulana` varchar(10) NOT NULL,
  `kode_obat` varchar(12) NOT NULL,
  `jumlah_obat` int(12) NOT NULL,
  `total_bayar` decimal(40,0) NOT NULL,
  `kode_pembeli` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `detail_penjualan`
--

INSERT INTO `detail_penjualan` (`no_penjulana`, `kode_obat`, `jumlah_obat`, `total_bayar`, `kode_pembeli`) VALUES
('PJ22102601', 'OBT0012', 1, '5000', 'PMB0001'),
('PJ22102602', '', 0, '0', 'PMB0002'),
('PJ22102603', '', 0, '0', 'PMB0003'),
('PJ22103101', 'OBT0016', 1, '1929929', 'PMB0004'),
('PJ22103102', 'OBT0016', 2, '3859858', 'PMB0005');

-- --------------------------------------------------------

--
-- Table structure for table `pembeli`
--

CREATE TABLE `pembeli` (
  `kd_pembeli` varchar(10) NOT NULL,
  `nama_pembeli` varchar(30) NOT NULL,
  `alamat_pembeli` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pembeli`
--

INSERT INTO `pembeli` (`kd_pembeli`, `nama_pembeli`, `alamat_pembeli`) VALUES
('PMB0001', 'IDIN', 'SEKOTONG');

-- --------------------------------------------------------

--
-- Table structure for table `pembelian_obat`
--

CREATE TABLE `pembelian_obat` (
  `kd_obat` varchar(12) NOT NULL,
  `nama_obat` varchar(20) NOT NULL,
  `tgl_pembelian` date NOT NULL,
  `exp` date NOT NULL,
  `harga` decimal(40,0) NOT NULL,
  `jumlah_obat` int(12) NOT NULL,
  `jenis_obat` varchar(10) NOT NULL,
  `kd_petugas` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pembelian_obat`
--

INSERT INTO `pembelian_obat` (`kd_obat`, `nama_obat`, `tgl_pembelian`, `exp`, `harga`, `jumlah_obat`, `jenis_obat`, `kd_petugas`) VALUES
('OBT0001', 'KETOCONAZOLE', '2022-10-18', '2023-10-18', '10000', 50, 'SALEP', 'PTG0041'),
('OBT0002', 'KALPALAX', '2022-10-17', '2023-10-17', '13000', 50, 'SALEP', 'PTG0041'),
('OBT0003', 'KALMICETINE', '2022-10-18', '2023-10-18', '17000', 50, 'SALEP', 'PTG0041'),
('OBT0004', 'MICONAZOLE NITRATE', '2022-10-18', '2023-10-18', '13000', 50, 'SALEP', 'PTG0041'),
('OBT0005', 'DATARIN CREAM', '2022-10-18', '2023-10-18', '26000', 50, 'SALEP', 'PTG0041'),
('OBT0006', 'HEXADOL', '2022-10-19', '2023-10-19', '73000', 30, 'SIRUP', 'PTG0041'),
('OBT0007', 'PARACETAMOL', '2022-10-19', '2023-10-19', '4000', 50, 'SERUP', 'PTG0041'),
('OBT0008', 'OBH COMBI', '2022-10-19', '2023-10-19', '28000', 30, 'SIRUP', 'PTG0041'),
('OBT0009', 'PROMAG', '2022-10-19', '2023-10-19', '14000', 40, 'SIRUP', 'PTG0041'),
('OBT0010', 'LASERIN', '2022-10-19', '2023-10-19', '12000', 40, 'SIRUP', 'PTG0041'),
('OBT0011', 'PANADOL', '2022-10-20', '2023-10-20', '12000', 50, 'TABLET', 'PTG0041'),
('OBT0012', 'Bodrex Flu & Batuk', '2022-10-20', '2023-10-20', '5000', 59, 'TABLET', 'PTG0041'),
('OBT0013', 'METFORMIN', '2022-10-20', '2023-10-20', '3000', 60, 'TABLET', 'PTG0041'),
('OBT0014', 'AMOXILIN', '2022-10-20', '2023-10-20', '10000', 60, 'TABLET', 'PTG0041'),
('OBT0015', 'ETHAMBOL', '2022-10-20', '2023-10-20', '2000', 60, 'TABLET', 'PTG0041'),
('OBT0016', 'KSDKS', '2022-10-29', '2025-07-17', '20000', 20, 'SDLSKD', 'PTG0041');

-- --------------------------------------------------------

--
-- Table structure for table `penjualan`
--

CREATE TABLE `penjualan` (
  `no_penjualan` varchar(10) NOT NULL,
  `tgl_penjualan` date NOT NULL,
  `kode_obat` varchar(12) NOT NULL,
  `nama_obat` varchar(20) NOT NULL,
  `exp` date NOT NULL,
  `harga_obat` decimal(12,0) NOT NULL,
  `jenis_obat` varchar(10) NOT NULL,
  `total_penjualan` int(12) NOT NULL,
  `kd_petugas` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `penjualan`
--

INSERT INTO `penjualan` (`no_penjualan`, `tgl_penjualan`, `kode_obat`, `nama_obat`, `exp`, `harga_obat`, `jenis_obat`, `total_penjualan`, `kd_petugas`) VALUES
('PJ22102601', '2022-10-26', 'OBT0012', 'Bodrex Flu & Batuk', '2023-10-20', '5000', 'TABLET', 1, 'PTG0041');

-- --------------------------------------------------------

--
-- Table structure for table `petugas`
--

CREATE TABLE `petugas` (
  `kd_petugas` varchar(8) NOT NULL,
  `nama_petugas` varchar(25) NOT NULL,
  `password` varchar(7) NOT NULL,
  `no_hp` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `petugas`
--

INSERT INTO `petugas` (`kd_petugas`, `nama_petugas`, `password`, `no_hp`) VALUES
(' PTG0022', 'IDIN', '2345', '098765443223'),
('PTG0041', 'Rian', '1234', '087864412536');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pembeli`
--
ALTER TABLE `pembeli`
  ADD PRIMARY KEY (`kd_pembeli`);

--
-- Indexes for table `pembelian_obat`
--
ALTER TABLE `pembelian_obat`
  ADD PRIMARY KEY (`kd_obat`),
  ADD KEY `kd_petugas` (`kd_petugas`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`no_penjualan`);

--
-- Indexes for table `petugas`
--
ALTER TABLE `petugas`
  ADD PRIMARY KEY (`kd_petugas`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `pembelian_obat`
--
ALTER TABLE `pembelian_obat`
  ADD CONSTRAINT `pembelian_obat_ibfk_1` FOREIGN KEY (`kd_petugas`) REFERENCES `petugas` (`kd_petugas`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
