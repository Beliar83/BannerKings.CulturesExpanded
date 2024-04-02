<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

	
	<xsl:template match="Settlement[@id='castle_A1']/@owner">
        <xsl:attribute name='owner'>Faction.bk_clan_kannic_2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_V3']/@owner">
        <xsl:attribute name='owner'>Faction.clan_vlandia_6</xsl:attribute>
    </xsl:template>

	<xsl:template match="Settlement[@id='town_A2']/@owner">
        <xsl:attribute name='owner'>Faction.fulq</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_village_S4_1']/@owner">
        <xsl:attribute name='owner'>Faction.bk_clan_vakken_2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_S7']/@owner">
        <xsl:attribute name='owner'>Faction.bk_clan_jumne_4</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_S1']/@owner">
        <xsl:attribute name='owner'>Faction.clan_sturgia_5</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_V9']/@owner">
        <xsl:attribute name='owner'>Faction.bk_clan_jumne_3</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_V5']/@owner">
        <xsl:attribute name='owner'>Faction.bk_clan_jumne_1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_V6']/@owner">
        <xsl:attribute name='owner'>Faction.bk_clan_jumne_2</xsl:attribute>
    </xsl:template>
	
	
	<xsl:template match="Settlement[@id='castle_K4']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_B1']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_B2']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_B3']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_B4']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_B5']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_B4']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_B7']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_K4']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_K5']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_K8']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_K3']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_K6']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_S1']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_S2']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_S4']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_S5']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_S6']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_S7']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_ES7']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_ES6']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_ES3']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_ES1']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_ES8']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_ES2']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_ES1']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_EW5']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_EW2']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_EW1']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_EW6']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_EN6']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_EN3']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_EN8']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_V8']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_V2']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_V6']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='town_V5']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_V1']/Components/Town/@level">
        <xsl:attribute name='level'>2</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Settlement[@id='castle_V4']/Components/Town/@level">
        <xsl:attribute name='level'>1</xsl:attribute>
    </xsl:template>

</xsl:stylesheet>

