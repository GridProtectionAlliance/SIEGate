![Icon](http://www.gridprotectionalliance.org/images/products/icons%2064/SIEGate.png)![SIEGate](http://www.gridprotectionalliance.org/images/products/SIEGate.png)
# SIEGate
Secure Information Exchange Gateway

![CodeQL](https://github.com/GridProtectionAlliance/SIEGate/workflows/CodeQL/badge.svg)

The objectives of the SIEGate (the Secure Information Exchange Gateway pronounced Psy-gate) project are (1) to improve the security posture and minimize the external cyber-attack surface of electric utility control centers, and (2) to reduce the cost of maintaining current control-room-to-control-room information exchange.

Funded by the U.S. Department of Energy, the project team includes the Grid Protection Alliance (GPA) as the project prime and principal software developer, with the University of Illinois at Urbana-Champaign (Illinois) as a research, design, development, and testing partner; the Pacific Northwest National Laboratory (PNNL) as a design review, testing, and evaluation partner; PJM as a demonstration partner; and Alstom Grid as a demonstration and commercialization partner. Work on SIEGate began in 2010 with the initial version published 2013.

## Overview

As shown below, SIEGate provides a security isolation layer between critical internal infrastructure and external systems to protect reliability and market sensitive data. SIEGate reduces the cost of data exchange through ease-of-configuration.

![SIEGate](https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/images/SIEGateUseCase.png)

SIEGate implements a true publish-subscribe architecture where the sending gateway owner authorizes data as available for subscription by specific consuming gateways. Once authorized, the consuming gateway automatically discovers the data that have been made available to it by other SIEGate nodes and allows the selective subscription to them. SIEGate data available for publication and subscription includes measurements, such as SCADA or synchrophasor data; files, such as SDX files; and higher-level notifications or alarms that are of significance for overall grid operation. These alarms may be configured to promulgate to all interconnected SIEGate nodes so that global alarms can be raised.

# Documentation and Support
* Documentation for SIEGate can be found [here](https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/SIEGate_Documentation.md).
* Get in contact with our development team on our new [discussion board](http://discussions.gridprotectionalliance.org/c/gpa-products/siegate).
* Check out the [wiki](https://gridprotectionalliance.org/wiki/doku.php?id=siegate:overview).

# Deployment

1. Make sure your system meets all the [requirements](#requirements) below.
* Choose a [download](#downloads) below.
* Unzip if necessary.
* Run SIEGateSetup.msi.
* Follow the wizard.
* Enjoy.

## Requirements

### Hardware Requirements

SIEGate has been designed for implementation on standard, high-availability hardware systems to reduce barriers to commercialization and use. It is targeted for production use on the "minimal installation" of Server Core for Windows Server 2008-R2 which eliminates all non-essential OS features and services.

### Software Requirements

* .NET 4.6 or higher.
* 64-bit Windows 7 or newer.
* Database management system such as:
  * SQL Server (Express version is fine)
  * MySQL
  * Oracle
  * PostgreSQL
  * SQLite\* (included, no extra install required)
  
\* Not recommended for large deployments.

## Downloads
* Download the latest stable release [here](https://github.com/GridProtectionAlliance/SIEGate/releases).
* Download the nightly build [here](https://www.gridprotectionalliance.org/nightlybuilds/SIEGate/Beta/SIEGate.Installs.zip).

# How to Contribute
If you would like to contribute please:

1. Read our [Coding Style Guidelines](https://www.gridprotectionalliance.org/docs/GPA_Coding_Guidelines_2011_03.pdf)
* Fork the GitHub repository
* Work your magic
* Make a pull request

# License

SIEGate is licensed for use under the [MIT License](https://github.com/GridProtectionAlliance/SIEGate/blob/master/LICENSE.txt).
