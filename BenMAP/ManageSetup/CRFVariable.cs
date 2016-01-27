﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenMAP
{
    public class CRFVariable
    {
        public CRFVariable(string varName, int varID, string pollName, int poll1ID)
        {
            this._variableName = varName;
            this._variableID = varID;
            this._pollutantName = pollName;
            this._pollutant1ID = poll1ID;
        }

        public CRFVariable(string varName, string pollName, int poll1ID)
        {
            this._variableName = varName;
            this._pollutantName = pollName;
            this._pollutant1ID = poll1ID;
        }

        public CRFVariable(string varName, int varID, string pollName, int poll1ID, int poll2ID)
        {
            this._variableName = varName;
            this._variableID = varID;
            this._pollutantName = pollName;
            this._pollutant1ID = poll1ID;
            this._pollutant2ID = poll2ID;
        }

        private int _variableID;
        public int VariableID
        {
            get { return _variableID; }
            set { _variableID = value; }
        }

        private int _functionID;
        public int FunctionID
        {
            get { return _functionID; }
            set { _functionID = value; }
        }

        private string _variableName;
        public string VariableName
        {
            get { return _variableName; }
            set { _variableName = value; }
        }

        private string _pollutantName;
        public string PollutantName
        {
            get { return _pollutantName; }
            set { _pollutantName = value; }
        }

        private int _pollutant1ID;
        public int Pollutant1ID
        {
            get { return _pollutant1ID; }
            set { _pollutant1ID = value; }
        }

        private int _pollutant2ID;
        public int Pollutant2ID
        {
            get { return _pollutant2ID; }
            set { _pollutant2ID = value; }
        }

        private List<CRFBeta> _pollBetas;
        public List<CRFBeta> PollBetas
        {
            get { return _pollBetas; }
            set { _pollBetas = value; }
        }
    }
}
