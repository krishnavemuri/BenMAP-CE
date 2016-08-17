using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BenMAP
{
    public class HealthImpact
    {
        public HealthImpact DeepCopy()
        {
            HealthImpact newCopy = new HealthImpact();

            if (this.Author == null) newCopy.Author = "";
            else newCopy.Author = String.Copy(this.Author);

            if (this.BaselineIncidenceFunction == null) newCopy.BaselineIncidenceFunction = "";
            else newCopy.BaselineIncidenceFunction = String.Copy(this.BaselineIncidenceFunction);

            if (this.BetaVariation == null) newCopy.BetaVariation = "";
            else newCopy.BetaVariation = String.Copy(this.BetaVariation);

            if (this.EndAge == null) newCopy.EndAge = "";
            else newCopy.EndAge = String.Copy(this.EndAge);

            if (this.Endpoint == null) newCopy.Endpoint = "";
            else newCopy.Endpoint = String.Copy(this.EndpointGroup);

            if (this.EndpointGroup == null) newCopy.EndpointGroup = "";
            else newCopy.EndpointGroup = String.Copy(this.EndpointGroup);

            if (this.Ethnicity == null) newCopy.Ethnicity = "";
            else newCopy.Ethnicity = String.Copy(this.Ethnicity);

            if (this.Function == null) newCopy.Function = "";
            else newCopy.Function = String.Copy(this.Function);

            if (this.FunctionID == null) newCopy.FunctionID = "";
            else newCopy.FunctionID = String.Copy(this.FunctionID);

            if (this.Gender == null) newCopy.Gender = "";
            else newCopy.Gender = String.Copy(this.Gender);

            if (this.Incidence == null) newCopy.Incidence = "";
            else newCopy.Incidence = String.Copy(this.Incidence);

            if (this.Location == null) newCopy.Location = "";
            else newCopy.Location = String.Copy(this.Location);

            if (this.LocationName == null) newCopy.LocationName = "";
            else newCopy.LocationName = String.Copy(this.LocationName);

            if (this.Metric == null) newCopy.Metric = "";
            else newCopy.Metric = String.Copy(this.Metric);

            if (this.MetricStatistic == null) newCopy.MetricStatistic = "";
            else newCopy.MetricStatistic = String.Copy(this.MetricStatistic);

            if (this.ModelSpec == null) newCopy.ModelSpec = "";
            else newCopy.ModelSpec = String.Copy(this.ModelSpec);

            if (this.OtherPollutant == null) newCopy.OtherPollutant = "";
            else newCopy.OtherPollutant = String.Copy(this.OtherPollutant);

            if (this.Pollutant == null) newCopy.Pollutant = "";
            else newCopy.Pollutant = String.Copy(this.Pollutant);

            /* newCopy.PollVariables = new List<CRFVariable>();
            newCopy.PollVariables.AddRange(this.PollVariables); */

            if (this.Prevalence == null) newCopy.Prevalence = "";
            else newCopy.Prevalence = String.Copy(this.Prevalence);

            if (this.Qualifier == null) newCopy.Qualifier = "";
            else newCopy.Qualifier = String.Copy(this.Qualifier);

            if (this.Race == null) newCopy.Race = "";
            else newCopy.Race = String.Copy(this.Race);

            if (this.Reference == null) newCopy.Reference = "";
            else newCopy.Reference = String.Copy(this.Reference);

            if (this.SeasonalMetric == null) newCopy.SeasonalMetric = "";
            else newCopy.SeasonalMetric = String.Copy(this.SeasonalMetric);

            if (this.StartAge == null) newCopy.StartAge = "";
            else newCopy.StartAge = String.Copy(this.StartAge);

            if (this.Variable == null) newCopy.Variable = "";
            else newCopy.Variable = String.Copy(this.Variable);

            if (this.Year == null) newCopy.Year = "";
            else newCopy.Year = String.Copy(this.Year);

            newCopy.PollVariables = new List<CRFVariable>();
            foreach (CRFVariable pv in this.PollVariables)
            {
                CRFVariable newVar = pv.DeepCopy();
                newCopy.PollVariables.Add(newVar);
            }

            /* int i = 0;
            foreach (var pv in newCopy.PollVariables)
            {
                if (pv.PollBetas == null)
                {
                    pv.PollBetas = new List<CRFBeta>();
                    if (this.PollVariables[i].PollBetas == null) { pv.PollBetas.Add(new CRFBeta()); }
                    else { pv.PollBetas.AddRange(this.PollVariables[i].PollBetas); }
                }
                i++;
            } */

            return newCopy;
        }

        private string _functionID;
        public string FunctionID
        {
            get { return _functionID; }
            set { _functionID = value; }
        }

        private string _endpointGroup;
        public string EndpointGroup
        {
            get { return _endpointGroup; }
            set { _endpointGroup = value; }
        }

        private string _endpoint;
        public string Endpoint
        {
            get { return _endpoint; }
            set { _endpoint = value; }
        }

        private string _pollutant;
        public string Pollutant
        {
            get { return _pollutant; }
            set { _pollutant = value; }
        }

        private string _metric;
        public string Metric
        {
            get { return _metric; }
            set { _metric = value; }
        }

        private string _metricStatistic;
        public string MetricStatistic
        {
            get { return _metricStatistic; }
            set { _metricStatistic = value; }
        }

        private string _seasonalMetric;
        public string SeasonalMetric
        {
            get { return _seasonalMetric; }
            set { _seasonalMetric = value; }
        }

        private string _race;
        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }

        private string _ethnicity;
        public string Ethnicity
        {
            get { return _ethnicity; }
            set { _ethnicity = value; }
        }

        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string _startAge;
        public string StartAge
        {
            get { return _startAge; }
            set { _startAge = value; }
        }

        private string _endAge;
        public string EndAge
        {
            get { return _endAge; }
            set { _endAge = value; }
        }

        private string _author;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        private string _year;
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private string _location;
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        private string _qualifier;
        public string Qualifier
        {
            get { return _qualifier; }
            set { _qualifier = value; }
        }

        private string _otherPollutant;
        public string OtherPollutant
        {
            get { return _otherPollutant; }
            set { _otherPollutant = value; }
        }

        private string _reference;
        public string Reference
        {
            get { return _reference; }
            set { _reference = value; }
        }

        private string _function;
        public string Function
        {
            get { return _function; }
            set { _function = value; }
        }

        private string _baselineIncidenceFunction;
        public string BaselineIncidenceFunction
        {
            get { return _baselineIncidenceFunction; }
            set { _baselineIncidenceFunction = value; }
        }

        private string _betaDistribution;
        public string BetaDistribution
        {
            get { return _betaDistribution; }
            set { _betaDistribution = value; }
        }

        private string _beta;
        public string Beta
        {
            get { return _beta; }
            set { _beta = value; }
        }

        private string _betaParameter1;
        public string BetaParameter1
        {
            get { return _betaParameter1; }
            set { _betaParameter1 = value; }
        }

        private string _betaParameter2;
        public string BetaParameter2
        {
            get { return _betaParameter2; }
            set { _betaParameter2 = value; }
        }

        private string _aConstantDescription;
        public string AConstantDescription
        {
            get { return _aConstantDescription; }
            set { _aConstantDescription = value; }
        }

        private string _bConstantDescription;
        public string BConstantDescription
        {
            get { return _bConstantDescription; }
            set { _bConstantDescription = value; }
        }

        private string _cconstantDescription;
        public string CConstantDescription
        {
            get { return _cconstantDescription; }
            set { _cconstantDescription = value; }
        }

        private string _aConstantValue;
        public string AConstantValue
        {
            get { return _aConstantValue; }
            set { _aConstantValue = value; }
        }

        private string _bConstantValue;
        public string BConstantValue
        {
            get { return _bConstantValue; }
            set { _bConstantValue = value; }
        }

        private string _cConstantValue;
        public string CConstantValue
        {
            get { return _cConstantValue; }
            set { _cConstantValue = value; }
        }
        private string _incidence;
        public string Incidence
        {
            get { return _incidence; }
            set { _incidence = value; }
        }
        private string _prevalence;
        public string Prevalence
        {
            get { return _prevalence; }
            set { _prevalence = value; }
        }
        private string _variable;
        public string Variable
        {
            get { return _variable; }
            set { _variable = value; }
        }

        private string _locationName;
        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }

        private List<CRFVariable> _pollVariables;
        public List<CRFVariable> PollVariables
        {
            get { return _pollVariables; }
            set { _pollVariables = value; }
        }

        private string _modelSpec;
        public string ModelSpec
        {
            get { return _modelSpec; }
            set { _modelSpec = value; }
        }

        private string _betaVariation;
        public string BetaVariation
        {
            get { return _betaVariation; }
            set { _betaVariation = value; }
        }

        private int _seasonalMetricID;
        public int SeasonalMetricID
        {
            get { return _seasonalMetricID; }
            set { _seasonalMetricID = value; }
        }
    }
}
