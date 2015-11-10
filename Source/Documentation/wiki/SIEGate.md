<html lang="en">
<head>
</head>
<body>
<!--HtmlToGmd.Body-->
<div id="NavigationMenu">
<h1><a href="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/SIEGate.md">
<img src="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/SIEGate_Logo.png" alt="SIEGate" /></a></h1>
<hr />
<table style="width: 100%; border-collapse: collapse; border: 0px solid gray;">
<tr>
<td style="width: 25%; text-align:center;"><b><a href="http://www.gridprotectionalliance.com">Grid Protection Alliance</a></b></td>
<td style="width: 25%; text-align:center;"><b><a href="https://github.com/GridProtectionAlliance/SIEGate">SIEGate Project on GitHub</a></b></td>
<td style="width: 25%; text-align:center;"><b><a href="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/SIEGate.md">SIEGate Wiki</a></b></td>
<td style="width: 25%; text-align:center;"><b><a href="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/SIEGate_Documentation.md">SIEGate Documentation</a></b></td>
</tr>
</table>
</div>
<hr />
<!--/HtmlToGmd.Body-->
<div class="WikiContent">
<div class="wikidoc">
<p><strong>The SIEGate Project</strong></p>
<p>The objectives of the SIEGate (the Secure Information Exchange Gateway pronounced Psy-gate) project are (1) to improve the security posture and minimize the external cyber-attack surface of electric utility control centers, and (2) to reduce the cost of
 maintaining current control-room-to-control-room information exchange.</p>
<p>Funded by the the U.S. Department of Energy, the project team includes the Grid Protection Alliance (GPA) as the project prime and principal software developer, with the University of Illinois at Urbana-Champaign (Illinois) as a research, design, development,
 and testing partner; the Pacific Northwest National Laboratory (PNNL) as a design review, testing, and evaluation partner; PJM as a demonstration partner; and Alstom Grid as a demonstration and commercialization partner. Work on SIEGate began in 2010 and is
 expected on conclude in 2013.</p>
<p><strong>Overview</strong></p>
<p>As shown below, SIEGate provides a security isolation layer between critical internal infrastructure and external systems to protect reliability and market sensitive data. SIEGate reduces the cost of data exchange through ease-of-configuration.</p>
<p style="text-align:center"><img src="https://github.com/GridProtectionAlliance/SIEGate/blob/master/Source/Documentation/wiki/files/SIEGate_Implementation_Diagram.png" alt="" width="480" style="vertical-align:middle"></p>
<p>SIEGate implements a true publish-subscribe architecture where the sending gateway owner authorizes data as available for subscription by specific consuming gateways. Once authorized, the consuming gateway automatically discovers the data that have been
 made available to it by other SIEGate nodes and allows the selective subscription to them. SIEGate data available for publication and subscription includes measurements, such as SCADA or synchrophasor data; files, such as SDX files; and higher-level notifications
 or alarms that are of significance for overall grid operation. These alarms may be configured to promulgate to all interconnected SIEGate nodes so that global alarms can be raised.</p>
<p><strong>Two Parallel Development Tracks</strong></p>
<p>SIEGate is being built upon the Grid Protection Alliance's <a title="GSF" href="https://github.com/GridProtectionAlliance/gsf" target="_blank">
Grid Solutions Framework</a> (GSF) and in this process the GSF framework has been extensively improved and extended throughout the SIEGate project. The SIEGate project also has benefited from foundational work on &quot;gateways&quot; that was conducted by GPA
 during it's development of the open phasor gateway, or <a title="openPG" href="https://openpg.codeplex.com/" target="_blank">
openPG</a>. This development approach of extension of existing production-grade software has resulted in a parallel development process for SIEGate.</p>
<p>Development Track 1 - <span style="text-decoration:underline">The SIEGate Advanced Core.</span> The SIEGate advanced core implements advanced principles of internal system isolation to preclude exploitation of one function to gain access to or disrupt functionality
 of another. The advanced core leverages the Disruptor high-performance inter-thread messaging library to manage the processing and isolation of information within SIEGate while minimizing latency and maximizing throughput.</p>
<p>Development Track 2 - <span style="text-decoration:underline">Other SIEGate Functionality.</span> In addition to the advanced core, SIEGate includes data delivery, data performance and security features. Development track 2 forms the kernel of the &quot;SIEGate
 Beta&quot;. Through this extension of tested, production grade software, it is believed SIEGate can be deployed within production environments while the Advanced Core undergoes rigorous testing and refinement to assure that it is production worthy.</p>
<p>Currently, source code for both development tracks is available on this site. These tracks are expected to come together as the SIEGate Version 1.0 Release Candidate in the summer of 2013.</p>
<p><strong>Hardware Requirements</strong></p>
<p>SIEGate has been designed for implementation on standard, high-availability hardware systems to reduce barriers to commercialization and use. It is targeted for production use on the &quot;minimal installation&quot; of Server Core for Windows Server 2008-R2
 which eliminates all non-essential OS features and services.</p>
</div>
</div>
<hr />
<div class="footer">
Last edited Jun 26, 2013 at 9:21:39 PM by <a id="wikiEditByLink" href="https://github.com/ritchiecarroll">ritchiecarroll</a>, version 24<br />
<!--HtmlToGmd.Migration-->Migrated from <a href="https://siegate.codeplex.com/">CodePlex</a> Nov 8, 2015 by <a href="https://github.com/ajstadlin">ajstadlin</a><!--/HtmlToGmd.Migration-->
</div>
<!--HtmlToGmd.Foot-->
<div id="copyright">
<hr />
Copyright 2015 <a href="http://www.gridprotectionalliance.org">Grid Protection Alliance</a>
</div>
<!--/HtmlToGmd.Foot-->
</body>
</html>