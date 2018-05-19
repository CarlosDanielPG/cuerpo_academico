-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 19-05-2018 a las 20:51:43
-- Versión del servidor: 5.7.21
-- Versión de PHP: 7.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `cuerpo_academico`
--
CREATE DATABASE IF NOT EXISTS `cuerpo_academico` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `cuerpo_academico`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `carrera`
--

DROP TABLE IF EXISTS `carrera`;
CREATE TABLE IF NOT EXISTS `carrera` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `id_nivel` int(10) NOT NULL,
  `id_division` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`),
  KEY `nivel` (`id_nivel`),
  KEY `division` (`id_division`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `carrera`
--

INSERT INTO `carrera` (`id`, `nombre`, `id_nivel`, `id_division`) VALUES
(1, 'Ingenieria en Computacion', 1, 1),
(2, 'Ingenieria en Informatica', 1, 1),
(3, 'Ingenieria en Electronica', 1, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `division`
--

DROP TABLE IF EXISTS `division`;
CREATE TABLE IF NOT EXISTS `division` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `division`
--

INSERT INTO `division` (`id`, `nombre`) VALUES
(4, 'DIVCB'),
(1, 'DIVEC'),
(9, 'DIVECI'),
(3, 'DIVEO'),
(5, 'DIVIN');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grado`
--

DROP TABLE IF EXISTS `grado`;
CREATE TABLE IF NOT EXISTS `grado` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `grado`
--

INSERT INTO `grado` (`id`, `nombre`) VALUES
(1, 'Licenciatura'),
(2, 'Especialidad'),
(3, 'Maestria'),
(4, 'Doctorado'),
(5, 'Postdoctorado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `institucion`
--

DROP TABLE IF EXISTS `institucion`;
CREATE TABLE IF NOT EXISTS `institucion` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `institucion`
--

INSERT INTO `institucion` (`id`, `nombre`) VALUES
(1, 'Institucion 1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `linea_investigacion`
--

DROP TABLE IF EXISTS `linea_investigacion`;
CREATE TABLE IF NOT EXISTS `linea_investigacion` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `descripcion` (`descripcion`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `linea_investigacion`
--

INSERT INTO `linea_investigacion` (`id`, `descripcion`) VALUES
(1, 'Linea 1'),
(2, 'Linea 2');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nivel_carrera`
--

DROP TABLE IF EXISTS `nivel_carrera`;
CREATE TABLE IF NOT EXISTS `nivel_carrera` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `nivel_carrera`
--

INSERT INTO `nivel_carrera` (`id`, `nombre`) VALUES
(1, 'Licenciatura'),
(2, 'TSU');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `produccion`
--

DROP TABLE IF EXISTS `produccion`;
CREATE TABLE IF NOT EXISTS `produccion` (
  `numero_registro` int(10) NOT NULL AUTO_INCREMENT,
  `titulo` varchar(50) NOT NULL,
  `anio` year(4) NOT NULL,
  `fecha_publicacion` date NOT NULL,
  `id_tipo_produccion` int(10) NOT NULL,
  `id_linea_investigacion` int(10) NOT NULL,
  `id_proposito` int(10) NOT NULL,
  `id_institucion_avaladora` int(10) NOT NULL,
  `cuenta_curriculum` tinyint(1) NOT NULL,
  PRIMARY KEY (`numero_registro`),
  UNIQUE KEY `titulo` (`titulo`),
  KEY `linea_investigacion` (`id_linea_investigacion`),
  KEY `proposito` (`id_proposito`),
  KEY `institucion_avaladora` (`id_institucion_avaladora`),
  KEY `id_tipo_produccion` (`id_tipo_produccion`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `produccion`
--

INSERT INTO `produccion` (`numero_registro`, `titulo`, `anio`, `fecha_publicacion`, `id_tipo_produccion`, `id_linea_investigacion`, `id_proposito`, `id_institucion_avaladora`, `cuenta_curriculum`) VALUES
(5, 'Produccion 1', 2018, '2018-05-18', 1, 2, 2, 1, 1),
(6, 'Produccion 2', 2017, '2018-05-16', 1, 1, 1, 1, 0),
(8, 'Produccion 3', 2018, '2018-05-18', 1, 2, 2, 1, 1),
(9, 'Produccion 4', 2018, '2018-05-24', 1, 1, 2, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profesor`
--

DROP TABLE IF EXISTS `profesor`;
CREATE TABLE IF NOT EXISTS `profesor` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  `apellido_paterno` varchar(20) NOT NULL,
  `apellido_materno` varchar(20) NOT NULL,
  `tipo_usuario` int(11) NOT NULL,
  `id_division` int(11) NOT NULL,
  `correo` varchar(40) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `tipo_usuario` (`tipo_usuario`),
  KEY `id_division` (`id_division`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `profesor`
--

INSERT INTO `profesor` (`id`, `nombre`, `apellido_paterno`, `apellido_materno`, `tipo_usuario`, `id_division`, `correo`, `password`) VALUES
(1, 'Carlos Daniel', 'Perez', 'Gutierrez', 1, 1, 'carlospdcg@hotmail.com', '8fe918632d847e8ea3ebffbd47bd8ca9'),
(2, 'Shamir Issai', 'Caro', 'Ortiz', 2, 1, 'shamir@mail.com', 'e10adc3949ba59abbe56e057f20f883e'),
(3, 'Christian', 'Vargas', 'Orozco', 2, 1, 'christian@mail.com', 'e10adc3949ba59abbe56e057f20f883e'),
(4, 'Hassem', 'Macias', 'Brambila', 3, 1, 'hassem@mail.com', 'e10adc3949ba59abbe56e057f20f883e'),
(5, 'Arturo', 'Ramirez', 'Jimenez', 2, 1, 'arturo@mail.com', 'e10adc3949ba59abbe56e057f20f883e'),
(6, 'Israel', 'Roman', 'Godinez', 4, 3, 'isra@el.com', 'e10adc3949ba59abbe56e057f20f883e');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profesor_colabora_produccion`
--

DROP TABLE IF EXISTS `profesor_colabora_produccion`;
CREATE TABLE IF NOT EXISTS `profesor_colabora_produccion` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `id_profesor` int(10) NOT NULL,
  `id_produccion` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_profesor` (`id_profesor`),
  KEY `id_produccion` (`id_produccion`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `profesor_colabora_produccion`
--

INSERT INTO `profesor_colabora_produccion` (`id`, `id_profesor`, `id_produccion`) VALUES
(3, 2, 6),
(8, 2, 5),
(9, 3, 5),
(10, 2, 8),
(11, 4, 8),
(12, 3, 9);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profesor_elabora_produccion`
--

DROP TABLE IF EXISTS `profesor_elabora_produccion`;
CREATE TABLE IF NOT EXISTS `profesor_elabora_produccion` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `id_profesor` int(10) NOT NULL,
  `id_produccion` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_profesor` (`id_profesor`),
  KEY `id_produccion` (`id_produccion`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `profesor_elabora_produccion`
--

INSERT INTO `profesor_elabora_produccion` (`id`, `id_profesor`, `id_produccion`) VALUES
(5, 1, 6),
(6, 3, 6),
(10, 1, 5),
(11, 2, 5),
(12, 4, 8),
(13, 2, 8),
(14, 1, 9),
(15, 2, 9),
(16, 3, 9);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profesor_grado`
--

DROP TABLE IF EXISTS `profesor_grado`;
CREATE TABLE IF NOT EXISTS `profesor_grado` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `id_profesor` int(10) NOT NULL,
  `id_grado` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_profesor` (`id_profesor`),
  KEY `id_grado` (`id_grado`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `profesor_grado`
--

INSERT INTO `profesor_grado` (`id`, `id_profesor`, `id_grado`) VALUES
(10, 2, 2),
(11, 2, 1),
(12, 1, 1),
(13, 1, 2),
(14, 3, 2),
(15, 4, 1),
(16, 5, 1),
(17, 6, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proposito`
--

DROP TABLE IF EXISTS `proposito`;
CREATE TABLE IF NOT EXISTS `proposito` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `descripcion` (`descripcion`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proposito`
--

INSERT INTO `proposito` (`id`, `descripcion`) VALUES
(1, 'Proposito 1'),
(2, 'Proposito 2');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_produccion`
--

DROP TABLE IF EXISTS `tipo_produccion`;
CREATE TABLE IF NOT EXISTS `tipo_produccion` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `descripcion` (`descripcion`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_produccion`
--

INSERT INTO `tipo_produccion` (`id`, `descripcion`) VALUES
(1, 'General');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_usuario`
--

DROP TABLE IF EXISTS `tipo_usuario`;
CREATE TABLE IF NOT EXISTS `tipo_usuario` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_usuario`
--

INSERT INTO `tipo_usuario` (`id`, `nombre`) VALUES
(1, 'Administrador'),
(2, 'Coordinador'),
(3, 'Integrante'),
(4, 'Colaborador');

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `carrera`
--
ALTER TABLE `carrera`
  ADD CONSTRAINT `carrera_ibfk_1` FOREIGN KEY (`id_division`) REFERENCES `division` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `carrera_ibfk_2` FOREIGN KEY (`id_nivel`) REFERENCES `nivel_carrera` (`id`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `produccion`
--
ALTER TABLE `produccion`
  ADD CONSTRAINT `produccion_ibfk_1` FOREIGN KEY (`id_proposito`) REFERENCES `proposito` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `produccion_ibfk_2` FOREIGN KEY (`id_institucion_avaladora`) REFERENCES `institucion` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `produccion_ibfk_3` FOREIGN KEY (`id_linea_investigacion`) REFERENCES `linea_investigacion` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `produccion_ibfk_4` FOREIGN KEY (`id_tipo_produccion`) REFERENCES `tipo_produccion` (`id`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `profesor`
--
ALTER TABLE `profesor`
  ADD CONSTRAINT `profesor_ibfk_1` FOREIGN KEY (`id_division`) REFERENCES `division` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `profesor_ibfk_2` FOREIGN KEY (`tipo_usuario`) REFERENCES `tipo_usuario` (`id`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `profesor_colabora_produccion`
--
ALTER TABLE `profesor_colabora_produccion`
  ADD CONSTRAINT `profesor_colabora_produccion_ibfk_1` FOREIGN KEY (`id_produccion`) REFERENCES `produccion` (`numero_registro`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `profesor_colabora_produccion_ibfk_2` FOREIGN KEY (`id_profesor`) REFERENCES `profesor` (`id`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `profesor_elabora_produccion`
--
ALTER TABLE `profesor_elabora_produccion`
  ADD CONSTRAINT `profesor_elabora_produccion_ibfk_1` FOREIGN KEY (`id_produccion`) REFERENCES `produccion` (`numero_registro`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `profesor_elabora_produccion_ibfk_2` FOREIGN KEY (`id_profesor`) REFERENCES `profesor` (`id`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `profesor_grado`
--
ALTER TABLE `profesor_grado`
  ADD CONSTRAINT `profesor_grado_ibfk_2` FOREIGN KEY (`id_grado`) REFERENCES `grado` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `profesor_grado_ibfk_3` FOREIGN KEY (`id_profesor`) REFERENCES `profesor` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
