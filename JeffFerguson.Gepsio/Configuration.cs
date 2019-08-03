using System.Collections.Generic;

namespace JeffFerguson.Gepsio
{

    /// <summary>
    /// A representation of all configurations of Gepsio.
    /// </summary>
    public class Configuration {

        private static Dictionary<string, string> NamespaceSchemaLocationDictionary;

        /// <summary>
        /// The constructor for the Configuration class.
        /// </summary>
        public Configuration(bool useStandardNamespaceSchemaLocations = true) {
            BuildNamespaceSchemaLocationDictionary(useStandardNamespaceSchemaLocations);
        }

        /// <summary>
        /// Builds a list of standard, pre-defined namespaces and
        /// corresponding schema locations.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Some XBRL document instances may contain facts that reference namespaces
        /// defined by external specifications and schemas. For example, the Document
        /// Information and Entity Information schema defines a namespace of
        /// http://xbrl.us/dei/2009-01-31. This namespace is defined by the schema at
        /// http://taxonomies.xbrl.us/us-gaap/2009/non-gaap/dei-2009-01-31.xsd.
        /// </para>
        /// <para>
        /// XBRL instances will not (generally) explictly load schemas defined by external
        /// specifications with a &gt;schemaRef&lt; tag; they may, however, define facts
        /// with the namespaces defined by these external specifications.
        /// </para>
        /// <para>
        /// This method builds a dictionary of standard, well-known, externally defined
        /// namespaces and corresponding schema locations so that, if Gepsio needs
        /// element information from one of these schemas, it knows where to find the
        /// corresponding schema.
        /// </para>
        /// <para>
        /// Some of these entries were collected from the following sources:
        /// <list type="bullet">
        /// <listitem>
        /// https://www.sec.gov/info/edgar/edgartaxonomies.xml
        /// </listitem>
        /// </list>
        /// </para>
        /// </remarks>
        private static void BuildNamespaceSchemaLocationDictionary(bool useStandard)
        {
            if (useStandard) {
                NamespaceSchemaLocationDictionary = new Dictionary<string, string>
                {
                    { "http://xbrl.us/dei/2009-01-31", "http://taxonomies.xbrl.us/us-gaap/2009/non-gaap/dei-2009-01-31.xsd" },
                    { "http://xbrl.us/us-gaap/2009-01-31", "http://taxonomies.xbrl.us/us-gaap/2009/elts/us-gaap-std-2009-01-31.xsd" },
                    { "http://xbrl.sec.gov/dei/2014-01-31", "http://xbrl.sec.gov/dei/2014/dei-2014-01-31.xsd" },
                    { "http://fasb.org/dis/fifvdtmp01/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-fifvdtmp01-2018-01-31.xsd" },
                    { "http://fasb.org/dis/fifvdtmp02/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-fifvdtmp02-2018-01-31.xsd" },
                    { "http://fasb.org/dis/idestmp011/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-idestmp011-2018-01-31.xsd" },
                    { "http://fasb.org/dis/idestmp012/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-idestmp012-2018-01-31.xsd" },
                    { "http://fasb.org/dis/idestmp021/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-idestmp021-2018-01-31.xsd" },
                    { "http://fasb.org/dis/idestmp022/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-idestmp022-2018-01-31.xsd" },
                    { "http://fasb.org/dis/idestmp03/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-idestmp03-2018-01-31.xsd" },
                    { "http://fasb.org/dis/idestmp04/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-idestmp04-2018-01-31.xsd" },
                    { "http://fasb.org/dis/leasestmp01/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-leasestmp01-2017-01-31.xsd" },
                    { "http://fasb.org/dis/leasestmp02/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-leasestmp02-2017-01-31.xsd" },
                    { "http://fasb.org/dis/leasestmp03/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-leasestmp03-2017-01-31.xsd" },
                    { "http://fasb.org/dis/leasestmp04/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-leasestmp04-2017-01-31.xsd" },
                    { "http://fasb.org/dis/leasestmp05/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-leasestmp05-2017-01-31.xsd" },
                    { "http://fasb.org/dis/leastmp01/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-leastmp01-2018-01-31.xsd" },
                    { "http://fasb.org/dis/leastmp02/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-leastmp02-2018-01-31.xsd" },
                    { "http://fasb.org/dis/leastmp03/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-leastmp03-2018-01-31.xsd" },
                    { "http://fasb.org/dis/leastmp04/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-leastmp04-2018-01-31.xsd" },
                    { "http://fasb.org/dis/leastmp05/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-leastmp05-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp011/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp011-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp011/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp011-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp012/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp012-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp012/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp012-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp02/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp02-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp02/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp02-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp03/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp03-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp03/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp03-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp04/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp04-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp04/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp04-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp041/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp041-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp041/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp041-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp05/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp05-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp05/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp05-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp06/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp06-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp06/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp06-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp07/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp07-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp07/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp07-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp08/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp08-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp08/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp08-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp09/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp09-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp09/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp09-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp102/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp102-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp102/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp102-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp103/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp103-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp103/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp103-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp104/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp104-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp104/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp104-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp105/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp105-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp105/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp105-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp111/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp111-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp111/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp111-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp112/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp112-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp112/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp112-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp121/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp121-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp121/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp121-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp122/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp122-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp122/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp122-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp123/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp123-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp123/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp123-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp125/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp125-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp125/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp125-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp131/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp131-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp131/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp131-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp141/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rbtmp141-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rbtmp141/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rbtmp141-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rcctmp01/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rcctmp01-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rcctmp01/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rcctmp01-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rcctmp03/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rcctmp03-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rcctmp03/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rcctmp03-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rcctmp04/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rcctmp04-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rcctmp04/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rcctmp04-2018-01-31.xsd" },
                    { "http://fasb.org/dis/rcctmp05/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/dis/us-gaap-dis-rcctmp05-2017-01-31.xsd" },
                    { "http://fasb.org/dis/rcctmp05/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/dis/us-gaap-dis-rcctmp05-2018-01-31.xsd" },
                    { "http://fasb.org/srt-roles/2018-01-31", "http://xbrl.fasb.org/srt/2018/elts/srt-roles-2018-01-31.xsd" },
                    { "http://fasb.org/srt-types/2018-01-31", "http://xbrl.fasb.org/srt/2018/elts/srt-types-2018-01-31.xsd" },
                    { "http://fasb.org/srt/2018-01-31", "http://xbrl.fasb.org/srt/2018/elts/srt-2018-01-31.xsd" },
                    { "http://fasb.org/us-gaap/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/elts/us-gaap-2017-01-31.xsd" },
                    { "http://fasb.org/us-gaap/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/elts/us-gaap-2018-01-31.xsd" },
                    { "http://fasb.org/us-roles/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/elts/us-roles-2017-01-31.xsd" },
                    { "http://fasb.org/us-roles/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/elts/us-roles-2018-01-31.xsd" },
                    { "http://fasb.org/us-types/2017-01-31", "http://xbrl.fasb.org/us-gaap/2017/elts/us-types-2017-01-31.xsd" },
                    { "http://fasb.org/us-types/2018-01-31", "http://xbrl.fasb.org/us-gaap/2018/elts/us-types-2018-01-31.xsd" },
                    { "http://xbrl.ifrs.org/taxonomy/2016-03-31/ifrs-full", "http://xbrl.ifrs.org/taxonomy/2016-03-31/full_ifrs/full_ifrs-cor_2016-03-31.xsd" },
                    { "http://xbrl.ifrs.org/taxonomy/2017-03-09/ifrs-full", "http://xbrl.ifrs.org/taxonomy/2017-03-09/full_ifrs/full_ifrs-cor_2017-03-09.xsd" },
                    { "http://xbrl.ifrs.org/taxonomy/2018-03-16/ifrs-full", "http://xbrl.ifrs.org/taxonomy/2018-03-16/full_ifrs/full_ifrs-cor_2018-03-16.xsd" },
                    { "http://xbrl.sec.gov/country/2016-01-31", "http://xbrl.sec.gov/country/2016/country-2016-01-31.xsd" },
                    { "http://xbrl.sec.gov/country/2017-01-31", "https://xbrl.sec.gov/country/2017/country-2017-01-31.xsd" },
                    { "http://xbrl.sec.gov/currency/2016-01-31", "http://xbrl.sec.gov/currency/2016/currency-2016-01-31.xsd" },
                    { "http://xbrl.sec.gov/currency/2017-01-31", "https://xbrl.sec.gov/currency/2017/currency-2017-01-31.xsd" },
                    { "http://xbrl.sec.gov/dei/2012-01-31", "http://xbrl.sec.gov/dei/2012/dei-2012-01-31.xsd" },
                    { "http://xbrl.sec.gov/dei/2018-01-31", "https://xbrl.sec.gov/dei/2018/dei-2018-01-31.xsd" },
                    { "http://xbrl.sec.gov/exch/2017-01-31", "http://xbrl.sec.gov/exch/2017/exch-2017-01-31.xsd" },
                    { "http://xbrl.sec.gov/exch/2018-01-31", "https://xbrl.sec.gov/exch/2018/exch-2018-01-31.xsd" },
                    { "http://xbrl.sec.gov/invest/2012-01-31", "http://xbrl.sec.gov/invest/2012/invest-2012-01-31.xsd" },
                    { "http://xbrl.sec.gov/invest/2013-01-31", "https://xbrl.sec.gov/invest/2013/invest-2013-01-31.xsd" },
                    { "http://xbrl.sec.gov/naics/2011-01-31", "http://xbrl.sec.gov/naics/2011/naics-2011-01-31.xsd" },
                    { "http://xbrl.sec.gov/naics/2017-01-31", "http://xbrl.sec.gov/naics/2017/naics-2017-01-31.xsd" },
                    { "http://xbrl.sec.gov/rr-cal/2012-01-31", "http://xbrl.sec.gov/rr/2012/rr-cal-2012-01-31.xsd" },
                    { "http://xbrl.sec.gov/rr-cal/2018-01-31", "https://xbrl.sec.gov/rr/2018/rr-cal-2018-01-31.xsd" },
                    { "http://xbrl.sec.gov/rr-def/2012-01-31", "http://xbrl.sec.gov/rr/2012/rr-def-2012-01-31.xsd" },
                    { "http://xbrl.sec.gov/rr-ent/2012-01-31", "http://xbrl.sec.gov/rr/2012/rr-ent-2012-01-31.xsd" },
                    { "http://xbrl.sec.gov/rr-ent/2018-01-31", "https://xbrl.sec.gov/rr/2018/rr-ent-2018-01-31.xsd" },
                    { "http://xbrl.sec.gov/rr-pre/2012-01-31", "http://xbrl.sec.gov/rr/2012/rr-pre-2012-01-31.xsd" },
                    { "http://xbrl.sec.gov/rr-pre/2018-01-31", "https://xbrl.sec.gov/rr/2018/rr-pre-2018-01-31.xsd" },
                    { "http://xbrl.sec.gov/rr/2012-01-31", "http://xbrl.sec.gov/rr/2012/rr-2012-01-31.xsd" },
                    { "http://xbrl.sec.gov/rr/2018-01-31", "https://xbrl.sec.gov/rr/2018/rr-2018-01-31.xsd" },
                    { "http://xbrl.sec.gov/sic/2011-01-31", "https://xbrl.sec.gov/sic/2011/sic-2011-01-31.xsd" },
                    { "http://xbrl.sec.gov/stpr/2011-01-31", "http://xbrl.sec.gov/stpr/2011/stpr-2011-01-31.xsd" },
                    { "http://xbrl.sec.gov/stpr/2018-01-31", "https://xbrl.sec.gov/stpr/2018/stpr-2018-01-31.xsd" }
                };
            } else {
                NamespaceSchemaLocationDictionary = new Dictionary<string, string>{};
            }
        }

        /// <summary>
        /// Adds the schema location of a specific namespace.
        /// If the namespace is already known the schema location will be updated.
        /// </summary>
        /// <param name="Namespace">
        /// The namespace to add/change.
        /// </param>
        /// <param name="Location">
        /// The location of the schema.
        /// </param>
        public void AddOrChangeNamespaceSchemaLocation(string Namespace, string Location) {
            NamespaceSchemaLocationDictionary[Namespace] = Location;
        }

        /// <summary>
        /// Provides the schema location of a specific namespace.
        /// </summary>
        /// <param name="Namespace">
        /// The namespace to lookup.
        /// </param>
        public string GetNamespaceSchemaLocation(string Namespace) {
            if (NamespaceSchemaLocationDictionary.ContainsKey(Namespace)) {
                return NamespaceSchemaLocationDictionary[Namespace];
            } else {
                return null;
            }
        }

        /// <summary>
        /// Provides the schema location dictionar.
        /// </summary>
        public Dictionary<string, string> GetNamespaceSchemaLocationDictionary() {
            return NamespaceSchemaLocationDictionary;
        }

        /// <summary>
        /// Removes the schema location of a specific namespace.
        /// </summary>
        /// <param name="Namespace">
        /// The namespace to remove.
        /// </param>
        public void RemoveNamespaceSchemaLocation(string Namespace) {
            NamespaceSchemaLocationDictionary.Remove(Namespace);
        }
    }
}