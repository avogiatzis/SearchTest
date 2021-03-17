
import './App.css';
import {
  AppBar,
  Button,
  Card,
  CardContent,
  Divider,
  Grid,
  Paper,
  TextField,
  Typography,
} from '@material-ui/core';
import { useState } from 'react';
import result from './API/results';
import validator from 'validator';
function App() {
  const [results, setResults] = useState([]);
  const [state, setState] = useState({ keyword: '', url: '' });
  const [error, setError] = useState(false);
  const handleChange = (event) => {
    const { value, name } = event.target;
    setState({ ...state, [name]: value });
  };

  const handleClick = async () => {
    if (validator.isURL(state.url)) {
      setError(false);
      const response = await result.Results(state.url, state.keyword);
      setResults(response);
    } else {
      setError(true);
    }
  };
  return (
    <div className='App'>
      <AppBar position='static' style={{height:50}}>
        <Typography style={{margin:'auto'}}>InfoTrack</Typography>
      </AppBar>
      <Paper style={{ height: '50%', padding: 25, margin:50 }}>
        <Grid container style={{ margin: 'auto' }}>
          <Grid item xs={6}>
            <TextField
              id='standard-basic'
              label='Keyword'
              name='keyword'
              onChange={handleChange}
            />
          </Grid>

          <Grid item xs={6}>
            <TextField
              id='standard-basic'
              label='Url'
              name='url'
              onChange={handleChange}
              type='url'
              error={error}
              helperText={error && 'Incorrect entry.'}
            />
          </Grid>
        </Grid>
        <div style={{ marginTop: 25 }}>
          <Button variant='contained' color='primary' onClick={handleClick}>
            Search
          </Button>
        </div>
        <div
          className='results-container'
          style={{ marginTop: 30, padding: 45 }}
        >
          <Card style={{ minHeight: 150, width: '40%', margin: 'auto' }}>
            <CardContent>
              <Typography style={{ marginBottom: 15 }}>Results</Typography>
              <Divider style={{ marginBottom: 25 }} />
              {results &&
                results.map((result, idx) => (
                  <Typography key={idx}>
                    {result.engine}: {result.results}
                  </Typography>
                ))}
            </CardContent>
          </Card>
        </div>
      </Paper>
    </div>
  );
}

export default App;
