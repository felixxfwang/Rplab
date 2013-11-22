<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Teachers.aspx.cs" Inherits="RPLab.Teachers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="article">
        <h2>师资队伍</h2>
        <p style="text-indent:0">武汉大学无线电探测研究中心目前有教授3人，副教授2人，讲师1人。</p>
        <div class="nav" >
            <a href="#hjc">侯杰昌</a>
            <a href="#khy">柯亨玉</a>
            <a href="#wxr">万显荣</a>
            <a href="#cf">程丰</a>
            <a href="#ryh">饶云华</a>
            <a href="#gzp">龚子平</a>
        </div>
        <a name="hjc" id="hjc"></a>
        <div class="teacher-box">
            <div class="teacher-photo">
                <img src="Images/teachers/houjiechang.jpg" />
            </div>
            <div class="teacher-name">
                <h3>侯杰昌</h3>
            </div>
            <div class="teacher-resume">
                <p>
                    曾任武汉大学校长。教授、博士生导师、空间物理学家，在电离层与电波传播关系的研究方面成果卓著，其中部分研究成果填补了国内空白。获得国家自然科学三等奖1项，全国科学大会奖2项、教育部科技进步一等奖3项。1992年被批准为国家级有突出贡献的中青年专家，1998年3月当选为九届全国人大代表，同年9月被评为全国模范教师。
                </p>
            </div>
            <div style="clear: both"></div>
        </div>

        <a name="khy" id="khy"></a>
        <div class="teacher-box">
            <div class="teacher-photo">
                <img src="Images/teachers/kehengyu.jpg" />
            </div>
            <div class="teacher-name">
                <h3>柯亨玉</h3>
            </div>
            <div class="teacher-resume">
                <p>
                    男，博士，教授，博士生导师。1982年1月大学毕业于武汉大学物理系，1989年6月硕士研究生业于武汉大学空间物理系，1996年7月博士研究生毕业于武汉大学电子信息学院，分别获理学学士、硕士和博士学位。1993年任副教授、1996年任教授。1998年起兼任湖北省宇航学会副理事，2000年起兼任湖北省科技发展咨询专家，2001年起兼任国家“863”计划资源与环境领域海洋监测主题专家组专家，中国电波传播学会副主任委员，电波科学学报编委，雷达学报编委，2003起兼任中国电子教育学会常务理事，曾任国家教委第二届高等学校理科“信息与电子科学”教学指导委员会“无线电物理学”教学指导组成员(1995-2000 年)。2007年起任国家电工电子实验教学示范中心主任。
                </p>
                <p>
                    长期以来从事电波传播与天线、电磁场理论与应用、复杂目标电磁散射、高频雷达海洋遥感技术等领域的教学和科学研究工作，先后主持和参加了国家自然科学基金、国家“863”计划、国防重点预先研究等方面的科研项目十余项，发表科研论文90余篇，与人合作出版学术专著一本。获得国家教委科技进步一等奖一项、二等奖一项、三等奖一项，中国工程物理研究院科技进步二等奖一项，与人合著《电磁场理论中的并矢Green函数》获中国图书奖，获国家自然科学基金特优和优秀结题项目各一项，作为“863”计划重大项目“高频地波雷达海洋环境监测技术”的参与者，负责高频地波雷达的天线与馈电系统研究，该项目2000年底通过了国家科技部的验收，被评价为海洋领域三个有创新意义的标志性成果之一。在长期的教学中,培养了博士和硕士十余人，获得过“中国宝钢集团全国优秀教师”、“湖北省有突出贡献中青年专家”、“武汉大学优秀研究生导师”、“武汉大学本科优秀教学奖”等称号。
                </p>
            </div>
            <div style="clear: both"></div>
        </div>

        <a name="wxr" id="wxr"></a>
        <div class="teacher-box">
            <div class="teacher-photo">
                <img src="Images/teachers/wanxianrong.jpg" />
            </div>
            <div class="teacher-name">
                <h3>万显荣</h3>
            </div>
            <div class="teacher-resume">
                <p>
                    男，1975年生。博士，教授，博士生导师，中国电子学会高级会员。2009年获湖北省自然科学基金杰出青年项目资助，为湖北省自然科学基金“无线电探测与信息获取”创新群体核心成员，2010年获武汉大学电子信息学院杰出人才培育项目首批资助。近十年来一直致力于低频段新体制雷达信息获取的研究，是武汉大学电波传播实验室的研究和教学骨干，主讲《信号与线性系统》、《微机原理与接口技术》和《雷达原理》等课程，主要研究方向包括：高频超视距雷达与外辐射源雷达系统和信号处理。
                </p>
                <p>
                    近年来独立主持约10项科研项目（国家自然科学基金3项，十一五863计划探索1项，教育部博士点博导类基金1项，湖北省杰出青年基金项目1项，中央基础科研业务费课题2项），作为技术骨干参加了“十五”、“十一五”国家863计划3个重点项目的研究。主持研发了多型（近程、中程和远程）高频地波雷达接收系统；率先开展高频地波雷达的射频干扰和电离层杂波抑制的研究，立足我国国情率先开展了基于OFDM波形的多波段外辐射源雷达实验研究。近年来在IEEE Transaction on Antenna an Propagation, IEEE Transaction on Goescience and Remote Sensing, IEEE Signal Processing Letters, IET Proceeding on Radar, Sonar and Navigation，《电子学报》，《电子与信息学报》，《系统工程与电子技术》，《电波科学学报》等国内外著名期刊发表论文SCI/EI检索论文约60篇，论文多次被澳大利亚、法国、加拿大和国内同行引用。
                </p>
            </div>
            <div style="clear: both"></div>
        </div>

        <a name="cf" id="cf"></a>
        <div class="teacher-box">
            <div class="teacher-photo">
                <img src="Images/teachers/chengfeng.jpg" />
            </div>
            <div class="teacher-name">
                <h3>程丰</h3>
            </div>
            <div class="teacher-resume">
                <p>男，博士，副教授，硕士生导师，主要研究方向为雷达信号处理、阵列信号处理与无线电海洋遥感。长期从事新体制雷达系统研制及其信号处理研究，目前已主持完成了国家自然科学基金、国防预研基金、横向科技开发等多项科研课题，并参加了国家自然科学基金、国家863计划重大项目、教育部科学技术重点研究等多个科研项目，在阵列信号处理、目标检测与跟踪、无线电海洋遥感等方面取得了一系列重要成果。发表研究论文30余篇，申请10项发明专利（已授权5项，其中含1项美国专利和1项澳大利亚专利），拥有软件著作权登记7项。2010年因高频地波雷达无源阵列校正的外国专利（美国专利US 7,667,639 B2，澳大利亚专利2006227098）获得中央财政和武汉市知识产权局的专项资助（共55万元）。主讲《雷达原理》、《随机信号分析》等课程。</p>

            </div>
            <div style="clear: both"></div>
        </div>

        <a name="ryh" id="ryh"></a>
        <div class="teacher-box">
            <div class="teacher-photo">
                <img src="Images/teachers/raoyunhua.jpg" />
            </div>
            <div class="teacher-name">
                <h3>饶云华</h3>
            </div>
            <div class="teacher-resume">
                <p>男，博士，副教授，硕士生导师。1995年毕业于哈尔滨工程大学，获工学学士学位。1995-1997年工作于国营武昌造船厂。2000年、2004年分别在华中科技大学获工学硕士与博士学位。主要从事新体制雷达研制、电路系统设计、信号处理、无线通信及传感器网络等方面的研究。主持和参加多项国家级、省部级和横向科研项目。以第1作者在《Chinese Journal of Electronics》和《Computer Communications》等国内外知名刊物和会议上发表论文10多篇，其中被SCI检索4篇，EI检索6篇。长期担任《电子学报》等国内外著名期刊审稿人。2008年获湖北省科技进步二等奖（2008J-251-2-063-026-R02，排名第2）。</p>

            </div>
            <div style="clear: both"></div>
        </div>

        <a name="gzp" id="gzp"></a>
        <div class="teacher-box">
            <div class="teacher-photo">
                <img src="Images/teachers/gongziping.jpg" />
            </div>
            <div class="teacher-name">
                <h3>龚子平</h3>
            </div>
            <div class="teacher-resume">
                <p>男，博士，讲师，生于1977年。主要从事电波传播与电磁散射、天线理论与设计、无线电海洋遥感、雷达数据分析等方面的研究。主持了国家自然科学基金项目、中央基础科研业务费课题、横向科技开发等多项科研课题，并参加了国家自然科学基金、国家863计划重大项目、教育部重点项目等多个科研项目，发表学术论文10余篇，申请专利3项，出版教材一本。</p>

            </div>
            <div style="clear: both"></div>
        </div>

    </div>
</asp:Content>
