<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output omit-xml-declaration="yes"/>
<xsl:template match="@*|node()">
	<xsl:copy>
		<xsl:apply-templates select="@*|node()"/>
	</xsl:copy>
</xsl:template>

	<xsl:template match="string[@id='str_culture_rich_name.vlandia']"/>
	<xsl:template match="string[@id='str_culture_description.vlandia']"/>
	
	<xsl:template match="string[@id='str_culture_rich_name.battania']"/>
	<xsl:template match="string[@id='str_culture_description.battania']"/>
	
	<xsl:template match="string[@id='str_culture_rich_name.khuzait']"/>
	<xsl:template match="string[@id='str_culture_description.khuzait']"/>
	
	<xsl:template match="string[@id='str_culture_rich_name.aserai']"/>
	<xsl:template match="string[@id='str_culture_description.aserai']"/>
	
	<xsl:template match="string[@id='str_culture_rich_name.sturgia']"/>
	<xsl:template match="string[@id='str_culture_description.sturgia']"/>
	
	<xsl:template match="string[@id='str_culture_rich_name.empire']"/>
	<xsl:template match="string[@id='str_culture_description.empire']"/>
	
</xsl:stylesheet>

