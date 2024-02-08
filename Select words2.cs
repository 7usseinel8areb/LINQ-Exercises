List<string> list = new List<string>()
            {
                "mum", "Amsterdam", "bloom"
            };
            var result = list.Where(i => i.ToLower().StartsWith('a') 
                                    && i.ToLower().EndsWith('m'));
            Console.WriteLine(string.Join(',',result))