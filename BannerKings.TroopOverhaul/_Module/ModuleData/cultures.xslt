<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>



    <xsl:template match="Culture[@id='empire']/@elite_basic_troop">
        <xsl:attribute name="elite_basic_troop">NPCCharacter.bk_imperial_squire</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='empire']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_imperial_levy</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='empire']/@name">
        <xsl:attribute name="name">Calradoi</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='empire']/@militia_party_template">
        <xsl:attribute name="militia_party_template">PartyTemplate.bkce_militia_empire_template</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='empire']/@melee_militia_troop">
        <xsl:attribute name="melee_militia_troop">NPCCharacter.bk_imperial_levy</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='empire']/@ranged_militia_troop">
        <xsl:attribute name="ranged_militia_troop">NPCCharacter.bk_imperial_levy_archer</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='empire']/@melee_elite_militia_troop">
        <xsl:attribute name="melee_elite_militia_troop">NPCCharacter.bk_imperial_militiaman</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='empire']/@ranged_elite_militia_troop">
        <xsl:attribute name="ranged_elite_militia_troop">NPCCharacter.bk_imperial_militiaman_archer</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='empire']/@default_party_template">
        <xsl:attribute name="default_party_template">PartyTemplate.bkce_militia_empire_template</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='empire']/basic_mercenary_troops">
        <basic_mercenary_troops>
            <template name="NPCCharacter.bk_imperial_mercenary" />
        </basic_mercenary_troops>
    </xsl:template>
	
	<xsl:template match="Culture[@id='empire']/@text">
        <xsl:attribute name="text">The Calradoi are the people of the Empire, though by now they have given their name to the entire continent which they dominate. A thousand years ago, they were an undistinguished tribe living in the hill country between the southern sea and the Battanian woods. One tradition set them apart from their neighbors - the Calradoi had no kings. Their citizenry has always taken an intense interest in the art of self-government, the balance between protecting the liberty of individuals and the needs of the state. Perhaps this is why they had a slight edge in the endless wars between one town and another, keeping armies in the field just a little longer, bouncing back just a little more quickly from a defeat. Some of their neighbors federated with them; others were overrun. Eventually the Calradoi formed an empire, which evolved into a monarchy in all but name. Their leaders are no longer distinguished civic elders but great landholders scattered across the continent; the striking force of their armies is no longer citizen-infantry but heavily armored cataphracts in the retinues of the wealthy. But they still take their civic traditions very seriously, believing that the Calradian ideal can unite a continent in peace, if only the ”barbarians” beyond their borders would agree to submit to it.</xsl:attribute>
    </xsl:template>	
	
	

    <xsl:template match="Culture[@id='aserai']/@elite_basic_troop">
        <xsl:attribute name="elite_basic_troop">NPCCharacter.bk_aserai_squire</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='aserai']/@militia_party_template">
        <xsl:attribute name="militia_party_template">PartyTemplate.bkce_militia_aserai_template</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='aserai']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_aserai_levy</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='aserai']/@name">
        <xsl:attribute name="name">Nahawasi</xsl:attribute>
    </xsl:template>
	
	
	<xsl:template match="Culture[@id='aserai']/@melee_militia_troop">
        <xsl:attribute name="melee_militia_troop">NPCCharacter.bk_aserai_levy</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='aserai']/@ranged_militia_troop">
        <xsl:attribute name="ranged_militia_troop">NPCCharacter.bk_aserai_levy_archer</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='aserai']/@melee_elite_militia_troop">
        <xsl:attribute name="melee_elite_militia_troop">NPCCharacter.bk_aserai_militiaman</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='aserai']/@ranged_elite_militia_troop">
        <xsl:attribute name="ranged_elite_militia_troop">NPCCharacter.bk_aserai_militiaman_archer</xsl:attribute>
    </xsl:template>
	
	

    <xsl:template match="Culture[@id='sturgia']/@elite_basic_troop">
        <xsl:attribute name="elite_basic_troop">NPCCharacter.bk_sturgia_squire</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='sturgia']/@militia_party_template">
        <xsl:attribute name="militia_party_template">PartyTemplate.bkce_militia_sturgia_template</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='sturgia']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_sturgian_levy</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='sturgia']/@name">
        <xsl:attribute name="name">Sturgiske</xsl:attribute>
    </xsl:template>
	
	
	<xsl:template match="Culture[@id='sturgia']/@melee_militia_troop">
        <xsl:attribute name="melee_militia_troop">NPCCharacter.bk_sturgian_levy</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='sturgia']/@ranged_militia_troop">
        <xsl:attribute name="ranged_militia_troop">NPCCharacter.bk_sturgian_levy_archer</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='sturgia']/@melee_elite_militia_troop">
        <xsl:attribute name="melee_elite_militia_troop">NPCCharacter.bk_sturgian_militiaman</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='sturgia']/@ranged_elite_militia_troop">
        <xsl:attribute name="ranged_elite_militia_troop">NPCCharacter.bk_sturgian_militiaman_archer</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='sturgia']/basic_mercenary_troops">
        <basic_mercenary_troops>
            <template name="NPCCharacter.bk_sturgia_mercenary" />
			<template name="NPCCharacter.bk_nord_mercenary" />
        </basic_mercenary_troops>
    </xsl:template>
	
	<xsl:template match="Culture[@id='sturgia']/notable_and_wanderer_templates">
        <notable_and_wanderer_templates>
          <template name="NPCCharacter.spc_wanderer_sturgia_0" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_1" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_2" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_3" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_4" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_5" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_6" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_7" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_8" />
		  <template name="NPCCharacter.spc_wanderer_sturgia_9" />
		  <template name="NPCCharacter.spc_notable_sturgia_0" />
		  <template name="NPCCharacter.spc_notable_sturgia_0b" />
		  <template name="NPCCharacter.spc_notable_sturgia_1" />
		  <template name="NPCCharacter.spc_notable_sturgia_2" />
		  <template name="NPCCharacter.spc_notable_sturgia_2b" />
		  <template name="NPCCharacter.spc_notable_sturgia_3" />
		  <template name="NPCCharacter.spc_notable_sturgia_3b" />
		  <template name="NPCCharacter.spc_notable_sturgia_3c" />
		  <template name="NPCCharacter.spc_notable_sturgia_4" />
		  <template name="NPCCharacter.spc_notable_sturgia_5" />
		  <template name="NPCCharacter.spc_notable_sturgia_6" />
		  <template name="NPCCharacter.spc_notable_sturgia_7" />
		  <template name="NPCCharacter.spc_notable_sturgia_8" />
		  <template name="NPCCharacter.spc_notable_sturgia_9" />
		  <template name="NPCCharacter.spc_notable_sturgia_10" />
		  <template name="NPCCharacter.spc_sturgia_headman_1" />
		  <template name="NPCCharacter.spc_sturgia_headman_2" />
		  <template name="NPCCharacter.spc_sturgia_headman_3" />
		  <template name="NPCCharacter.spc_notable_vakken_0" />
        </notable_and_wanderer_templates>
    </xsl:template>
	
	

    <xsl:template match="Culture[@id='vlandia']/@elite_basic_troop">
        <xsl:attribute name="elite_basic_troop">NPCCharacter.bk_vlandia_squire</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='vlandia']/@militia_party_template">
        <xsl:attribute name="militia_party_template">PartyTemplate.bkce_militia_vlandia_template</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='vlandia']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_vlandia_levy</xsl:attribute>
    </xsl:template>	
	
	<xsl:template match="Culture[@id='vlandia']/@melee_militia_troop">
        <xsl:attribute name="melee_militia_troop">NPCCharacter.bk_vlandia_levy</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='vlandia']/@ranged_militia_troop">
        <xsl:attribute name="ranged_militia_troop">NPCCharacter.bk_vlandia_levy_longbow</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='vlandia']/@melee_elite_militia_troop">
        <xsl:attribute name="melee_elite_militia_troop">NPCCharacter.bk_vlandia_militiaman</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='vlandia']/@ranged_elite_militia_troop">
        <xsl:attribute name="ranged_elite_militia_troop">NPCCharacter.bk_vlandia_militiaman_longbow</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='vlandia']/@text">
        <xsl:attribute name="text">Claiming themselves the descendants of Osric Iron-Arm, the Osrickin are one the largest Wilunding tribes that migrated from west-over-seas. Among the original tribes, the Osrickin hold the greatest sway, represented by Derthert dey Meroc, who styles himself 'King of all the Wilunding' - a comfortable lie. Theirs is also the tradition of horsemanship and gallantry, which they hold highest amongst the original tribes. The Osrickin, having consolidated power over the Calradoi, were at the vanguard of reorganizing their kingdom into a feudal, organized structure, rather than a confederation of squabbling tribes. Such ideas were taken from the conquered Calradoi institutions and nobility, many of whom intermarried with the newly-settling Wilunding families - an easier choice than being butchered. Such mixing created a culture and language distinctively divergent from their original Wilunding origins. For relegating the other tribes to inferior positions, as well as their increasingly Calradoi-like tendencies, other Wilunding tribes accuse the Osrickin of betraying tradition, and claim their lineage a farse.</xsl:attribute>
    </xsl:template>	
	
	
	
    <xsl:template match="Culture[@id='battania']/@elite_basic_troop">
        <xsl:attribute name="elite_basic_troop">NPCCharacter.bk_battanian_squire</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='battania']/@militia_party_template">
        <xsl:attribute name="militia_party_template">PartyTemplate.bkce_militia_battania_template</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='battania']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_battanian_levy</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='battania']/@name">
        <xsl:attribute name="name">Battaneid</xsl:attribute>
    </xsl:template>
	
	
	<xsl:template match="Culture[@id='battania']/@melee_militia_troop">
        <xsl:attribute name="melee_militia_troop">NPCCharacter.bk_battanian_levy</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='battania']/@ranged_militia_troop">
        <xsl:attribute name="ranged_militia_troop">NPCCharacter.bk_battanian_levy_archer</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='battania']/@melee_elite_militia_troop">
        <xsl:attribute name="melee_elite_militia_troop">NPCCharacter.bk_battanian_militiaman</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='battania']/@ranged_elite_militia_troop">
        <xsl:attribute name="ranged_elite_militia_troop">NPCCharacter.bk_battanian_militiaman_archer</xsl:attribute>
    </xsl:template>
	
	

    <xsl:template match="Culture[@id='khuzait']/@elite_basic_troop">
        <xsl:attribute name="elite_basic_troop">NPCCharacter.bk_khuzait_squire</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='khuzait']/@militia_party_template">
        <xsl:attribute name="militia_party_template">PartyTemplate.bkce_militia_khuzait_template</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='khuzait']/@basic_troop">
        <xsl:attribute name="basic_troop">NPCCharacter.bk_khuzait_levy</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='khuzait']/@name">
        <xsl:attribute name="name">Devseg</xsl:attribute>
    </xsl:template>
	
	
	<xsl:template match="Culture[@id='khuzait']/@melee_militia_troop">
        <xsl:attribute name="melee_militia_troop">NPCCharacter.bk_khuzait_militiaman_lancer</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='khuzait']/@ranged_militia_troop">
        <xsl:attribute name="ranged_militia_troop">NPCCharacter.bk_khuzait_levy</xsl:attribute>
    </xsl:template>
	
	<xsl:template match="Culture[@id='khuzait']/@melee_elite_militia_troop">
        <xsl:attribute name="melee_elite_militia_troop">NPCCharacter.bk_khuzait_militiaman_infantry</xsl:attribute>
    </xsl:template>

    <xsl:template match="Culture[@id='khuzait']/@ranged_elite_militia_troop">
        <xsl:attribute name="ranged_elite_militia_troop">NPCCharacter.bk_khuzait_militiaman</xsl:attribute>
    </xsl:template>
	
</xsl:stylesheet>