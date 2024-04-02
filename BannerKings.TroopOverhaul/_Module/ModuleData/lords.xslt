<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

	<xsl:template match="NPCCharacter[@id='lord_4_6']/@culture">
        <xsl:attribute name="culture">Culture.rhodok</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="NPCCharacter[@id='lord_V11_l']/@culture">
        <xsl:attribute name="culture">Culture.rhodok</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="NPCCharacter[@id='lord_4_21']/@culture">
        <xsl:attribute name="culture">Culture.swadia</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="NPCCharacter[@id='lord_4_23']/@culture">
        <xsl:attribute name="culture">Culture.swadia</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="NPCCharacter[@id='lord_4_27']/@culture">
        <xsl:attribute name="culture">Culture.swadia</xsl:attribute>
    </xsl:template>
	


	
</xsl:stylesheet>