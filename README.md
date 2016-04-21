# SIEGate
Secure Information Exchange Gateway

The objectives of the SIEGate (the Secure Information Exchange Gateway pronounced Psy-gate) project are (1) to improve the security posture and minimize the external cyber-attack surface of electric utility control centers, and (2) to reduce the cost of maintaining current control-room-to-control-room information exchange.

Funded by the the U.S. Department of Energy, the project team includes the Grid Protection Alliance (GPA) as the project prime and principal software developer, with the University of Illinois at Urbana-Champaign (Illinois) as a research, design, development, and testing partner; the Pacific Northwest National Laboratory (PNNL) as a design review, testing, and evaluation partner; PJM as a demonstration partner; and Alstom Grid as a demonstration and commercialization partner. Work on SIEGate began in 2010 with the initial version published 2013.

## Overview

As shown below, SIEGate provides a security isolation layer between critical internal infrastructure and external systems to protect reliability and market sensitive data. SIEGate reduces the cost of data exchange through ease-of-configuration.

![SIEGate](https://www.gridprotectionalliance.org/docs/products/siegate/SIEGateUseCase.png)

SIEGate implements a true publish-subscribe architecture where the sending gateway owner authorizes data as available for subscription by specific consuming gateways. Once authorized, the consuming gateway automatically discovers the data that have been made available to it by other SIEGate nodes and allows the selective subscription to them. SIEGate data available for publication and subscription includes measurements, such as SCADA or synchrophasor data; files, such as SDX files; and higher-level notifications or alarms that are of significance for overall grid operation. These alarms may be configured to promulgate to all interconnected SIEGate nodes so that global alarms can be raised.

## Hardware Requirements

SIEGate has been designed for implementation on standard, high-availability hardware systems to reduce barriers to commercialization and use. It is targeted for production use on the "minimal installation" of Server Core for Windows Server 2008-R2 which eliminates all non-essential OS features and services.
